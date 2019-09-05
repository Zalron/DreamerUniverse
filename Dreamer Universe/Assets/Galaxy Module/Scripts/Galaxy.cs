using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
namespace GalaxyModule
{
    public class Galaxy : MonoBehaviour
    {
        [Header("Performance")]
        public bool enableThreading;
        public StarType[] starTypeTable;
        public Planet[] planetTypeTable;
        public SectorSO[] SectorTypeTable;

        public Mesh sphereMesh;
        public GameObject player;

        List<Sector> galaxySectors;
        public SectorCoord playerSectorCoord;
        SectorCoord playerLastSectorCoord;
        
        static int _seed = 5957362;

        public System.Random randomNumber = new System.Random(_seed);
        public Vector3 playerSectorCoordVector;

        public static int SectorSize = 1000;

        public static int galaxyHeight = 120; // the height of the Galaxy
        public static int galaxyLength = 1000; // the length of the Galaxy
        public static int galaxyWidth = 1000; // the width of the Galaxy

        public List<Sector> createdSectors = new List<Sector>();
        public List<SectorCoord> activeSectors = new List<SectorCoord>();
        public List<SectorCoord> sectorsToCreate = new List<SectorCoord>();
        public List<Sector> sectorsToUpdate = new List<Sector>();
        public Queue<Sector> sectorsToDraw = new Queue<Sector>();
        public int UpdateThreadNumber = 3;
        Thread sectorUpdateThread1;
        Thread sectorUpdateThread2;
        Thread sectorUpdateThread3;
        Thread sectorUpdateThread4;
        Thread sectorUpdateThread5;
        public object SectorUpdateThreadLock = new object();
        public static readonly int ViewDistanceInSectors = 1;

        // Start is called before the first frame update
        void Start()
        {
            if(enableThreading)
            {
                if (UpdateThreadNumber == 1)
                {
                    sectorUpdateThread1 = new Thread(new ThreadStart(ThreadedUpdate));
                    sectorUpdateThread1.Start();
                }
                if (UpdateThreadNumber == 2)
                {
                    sectorUpdateThread1 = new Thread(new ThreadStart(ThreadedUpdate));
                    sectorUpdateThread1.Start();
                    sectorUpdateThread2 = new Thread(new ThreadStart(ThreadedUpdate));
                    sectorUpdateThread2.Start();
                }
                if (UpdateThreadNumber == 3)
                {
                    sectorUpdateThread1 = new Thread(new ThreadStart(ThreadedUpdate));
                    sectorUpdateThread1.Start();
                    sectorUpdateThread2 = new Thread(new ThreadStart(ThreadedUpdate));
                    sectorUpdateThread2.Start();
                    sectorUpdateThread3 = new Thread(new ThreadStart(ThreadedUpdate));
                    sectorUpdateThread3.Start();
                }
                if (UpdateThreadNumber == 4)
                {
                    sectorUpdateThread1 = new Thread(new ThreadStart(ThreadedUpdate));
                    sectorUpdateThread1.Start();
                    sectorUpdateThread2 = new Thread(new ThreadStart(ThreadedUpdate));
                    sectorUpdateThread2.Start();
                    sectorUpdateThread3 = new Thread(new ThreadStart(ThreadedUpdate));
                    sectorUpdateThread3.Start();
                    sectorUpdateThread4 = new Thread(new ThreadStart(ThreadedUpdate));
                    sectorUpdateThread4.Start();
                }
                if (UpdateThreadNumber == 5)
                {
                    sectorUpdateThread1 = new Thread(new ThreadStart(ThreadedUpdate));
                    sectorUpdateThread1.Start();
                    sectorUpdateThread2 = new Thread(new ThreadStart(ThreadedUpdate));
                    sectorUpdateThread2.Start();
                    sectorUpdateThread3 = new Thread(new ThreadStart(ThreadedUpdate));
                    sectorUpdateThread3.Start();
                    sectorUpdateThread4 = new Thread(new ThreadStart(ThreadedUpdate));
                    sectorUpdateThread4.Start();
                    sectorUpdateThread5 = new Thread(new ThreadStart(ThreadedUpdate));
                    sectorUpdateThread5.Start();
                }
                //Debug.Log("Yub");
            }
            GenerateGalaxy((int)(player.transform.position.x / SectorSize), (int)(player.transform.position.y / SectorSize), (int)(player.transform.position.z / SectorSize), ViewDistanceInSectors);
            player.transform.position = new Vector3(500,500,500);
            playerLastSectorCoord = GetSectorCoordFromVector3(player.transform.position);
        }
        private void OnDisable()
        {   
            if(enableThreading)
            {
                sectorUpdateThread1.Abort();
            }
        }
        void ThreadedUpdate()
        {
            while (true)
            {
                if (sectorsToUpdate.Count > 0)
                {
                    //Debug.Log("Yub");
                    ThreadCreateSectors();
                }
            }
        }
        void Update()
        {
            playerSectorCoord = GetSectorCoordFromVector3(player.transform.position);
            playerSectorCoordVector = GetSectorVectorFromSectorCoord(playerSectorCoord);
            if (!playerSectorCoord.Equals(playerLastSectorCoord))
            {
                CheckViewDistance();
            }
            if(sectorsToDraw.Count > 0)
            {
                if (sectorsToDraw.Peek().IsEditable)
                {
                    //Debug.Log("I am creating");
                    sectorsToDraw.Dequeue().Init();
                }
            }
            if(sectorsToCreate.Count > 0)
            {
                CreateSector();
                //Debug.Log("CreatingSectors");
            }
            if(!enableThreading)
            {
                if (sectorsToUpdate.Count > 0)
                {
                    ThreadCreateSectors();
                }
            }
            
        }
        void GenerateGalaxy(int x, int y, int z, int startradius)// builds Sectors around the player
        {
            for (int startx = x - startradius; startx <= x + startradius; startx++)
            {
                for (int starty = y - startradius; starty <= y + startradius; starty++)
                {
                    for (int startz = z - startradius; startz <= z + startradius; startz++)
                    {
                        SectorCoord NewSectorCoord = new SectorCoord(startx, starty, startz);
                        sectorsToCreate.Add(NewSectorCoord);
                        activeSectors.Add(NewSectorCoord);
                        //Debug.Log("Generated Sector on Start" + " " + startx + " " + starty + " " + startz);
                    }
                }
            }
            CheckViewDistance();
        }
        void CheckViewDistance()
        {
            SectorCoord sectorCoord = GetSectorCoordFromVector3(player.transform.position);
            playerLastSectorCoord = playerSectorCoord;
            List<SectorCoord> previouslyActiveSectors = new List<SectorCoord>(activeSectors);
            activeSectors.Clear();
            for (int x = sectorCoord.x - ViewDistanceInSectors; x <= sectorCoord.x + ViewDistanceInSectors; x++)
            {
                for (int y = sectorCoord.y - ViewDistanceInSectors; y <= sectorCoord.y + ViewDistanceInSectors; y++)
                {
                    for (int z = sectorCoord.z - ViewDistanceInSectors; z <= sectorCoord.z + ViewDistanceInSectors; z++)
                    {
                        SectorCoord NewSectorCoord = new SectorCoord(x,y,z);
                        if (IsSectorInGalaxy(NewSectorCoord))
                        {
                            //bool IsCreatedBefore = IsSectorCreatedBefore(NewSectorCoord, previouslyActiveSectors);
                            //if ( IsCreatedBefore == true)
                            //{
                            //    ReturnSector(NewSectorCoord, previouslyActiveSectors);
                            //    sectorsToCreate.Add(NewSectorCoord);
                            //}
                            //Debug.Log("CheckViewDistance" + " " + x + " " + y + " " + z);
                            sectorsToCreate.Add(NewSectorCoord);
                            activeSectors.Add(NewSectorCoord);
                        }
                        for (int i = 0; i < previouslyActiveSectors.Count; i++)
                        {
                            if (previouslyActiveSectors[i].Equals(NewSectorCoord))
                            {
                                previouslyActiveSectors.RemoveAt(i);
                            }
                        }
                    }
                }
            }
            foreach (SectorCoord c in previouslyActiveSectors)
            {
                for (int i = 0; i < activeSectors.Count; i++)
                {
                    if (activeSectors[i] == c)
                    {
                        activeSectors.Remove(c);
                    }
                }

                for (int i = 0; i < createdSectors.Count; i++)
                {
                    createdSectors[i].IsActive = false;
                }
            }
            //Debug.Log("CheckViewDistance");
        }
        SectorCoord GetRawSectorCoordFromVector3(Vector3 pos)
        {
            int x = (int)pos.x;
            int y = (int)pos.y;
            int z = (int)pos.z;
            return new SectorCoord(x, y, z);
        }
        SectorCoord GetSectorCoordFromVector3(Vector3 pos)
        {
            int x = Mathf.FloorToInt(pos.x / SectorSize);
            int y = Mathf.FloorToInt(pos.y / SectorSize);
            int z = Mathf.FloorToInt(pos.z / SectorSize);
            return new SectorCoord(x, y, z);
        }
        public Vector3 GetSectorVectorFromSectorCoord(SectorCoord sectorCoord)
        {
            Vector3 sectorCoordVector3convert;
            sectorCoordVector3convert.x = sectorCoord.x;
            sectorCoordVector3convert.y = sectorCoord.y;
            sectorCoordVector3convert.z = sectorCoord.z;
            return sectorCoordVector3convert;
        }
        void ThreadCreateSectors()
        {
            bool updated = false;
            int index = 0;
            //Debug.Log("bla");
            lock(SectorUpdateThreadLock)
            {
                //Debug.Log(sectorsToUpdate.Count);
                while (!updated && index < sectorsToUpdate.Count - 1)
                {
                    //Debug.Log(sectorsToUpdate[index].IsActive);
                    if (sectorsToUpdate[index].IsActive)
                    {
                        sectorsToUpdate[index].UpdateSector();
                        activeSectors.Add(sectorsToUpdate[index].sectorCoord);
                        sectorsToUpdate.RemoveAt(index);
                        updated = true;
                        //Debug.Log("bla3");
                    }
                    else
                    {
                        index++;
                        //Debug.Log("bla4");
                    }
                }
                //Debug.Log("bla1");
            }
            
        }
        void CreateSector()
        {
            SectorCoord s = sectorsToCreate[0];
            GenerateSectorAt(s.x, s.y, s.z);
            sectorsToCreate.RemoveAt(0);
            //Debug.Log("" + s.x + "" + s.y + "" + s.z);
        }
        void GenerateSectorAt(int x, int y, int z)// builds Sectors
        {
            Vector3 SectorPosition = new Vector3(x * SectorSize, y * SectorSize, z * SectorSize);
            SectorCoord rawSectorCoord = GetRawSectorCoordFromVector3(SectorPosition);
            SectorCoord sectorCoord = GetSectorCoordFromVector3(SectorPosition);
            Sector i = new Sector(sectorCoord, rawSectorCoord, sphereMesh, this);
            {
                i.IsActive = true;
                sectorsToUpdate.Add(i);
                createdSectors.Add(i);
            }
            //Debug.Log(" " + SectorPosition.x + " " + SectorPosition.y + " " + SectorPosition.z + " " + i.IsActive);
            //Debug.Log(" " + sectorCoord.x + " " + sectorCoord.y + " " + sectorCoord.z + " " + i.IsActive);
        }
        Sector ReturnSector(SectorCoord coord, List<Sector> previouslyActiveSectors)
        {
            for(int i = 0; i < createdSectors.Count; i++)
            {
                if(createdSectors[i].sectorCoord == coord && previouslyActiveSectors[i].sectorCoord == coord)
                {
                    return createdSectors[i];
                }
            }
            return null;
        }
        bool IsSectorCreatedBefore(SectorCoord coord, List<Sector> previouslyActiveSectors)
        {
            for(int i = 0; i < createdSectors.Count; i++)
            {
                if(createdSectors[i].sectorCoord == coord && previouslyActiveSectors[i].sectorCoord == coord)
                {
                    return true;
                }
            }
            return false;
        }
        bool IsSectorInGalaxy(SectorCoord coord)
        {
            if (coord.x >= -galaxyLength && coord.x <= galaxyLength 
                && coord.y >= -galaxyHeight && coord.y <= galaxyHeight 
                && coord.z >= -galaxyWidth && coord.z <= galaxyWidth)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        bool IsStarSystemInGalaxy(Vector3 pos)
        {
            if (pos.x >= 0 && pos.x < galaxyLength 
                && pos.y >= 0 && pos.y < galaxyHeight 
                && pos.z >= 0 && pos.z < galaxyWidth)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
