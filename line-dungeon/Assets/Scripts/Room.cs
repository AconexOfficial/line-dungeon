using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    [SerializeField] private int roomID = 0;

    private int totalPaths = 0;

    private Path[] pathing = new Path[4];

    void AddPath(Room otherRoom)
    {
        if (totalPaths < 4)
        {
            Path path = new Path(this.roomID, otherRoom.roomID);
            pathing[totalPaths - 1] = path;
            totalPaths++;
        }
    }

    int TotalPaths()
    {
        return totalPaths;
    }



}
