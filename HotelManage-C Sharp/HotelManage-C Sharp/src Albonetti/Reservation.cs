using System;

public class Reservation
{
    private Client client;
    private Room room;
    private DateTime dateIn;
    private DateTime dateOut;

    public Reservation(Client client, DateTime dateIn, DateTime dateOut, Room room)
    {
        this.client = client;
        this.dateIn = dateIn;
        this.dateOut = dateOut;
        this.room = room;
    }

    public Client Client
    {
        get { return this.client;}
        set { this.client = value;}
    }

    public DateTime DateIn
    {
        get { return this.dateIn;}
        set { this.dateIn = value;}
    }

    public DateTime DateOut
    {
        get { return this.dateOut;}
        set { this.dateOut = value;}
    }

    public Room Room
    {
        get { return this.room;}
        set { this.room = value;}
    }
}
