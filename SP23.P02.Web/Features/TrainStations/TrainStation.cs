﻿using SP23.P02.Web.Features.Users;

namespace SP23.P02.Web.Features.TrainStations;

public class TrainStation
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Address { get; set; }

    public User? Manager { get; set; }
}