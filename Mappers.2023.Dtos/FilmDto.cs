﻿namespace Mappers._2023.Dtos;

public class FilmDto
{
    public string Title { get; set; }
    public int EpisodeId { get; set; }
    public string OpeningCrawl { get; set; }
    public string Director { get; set; }
    public string Producer { get; set; }
    public DateTime ReleaseDate { get; set; }
    public DateTime Created { get; set; }
    public DateTime Edited { get; set; }
    public TimeSpan TimeSinceRelease { get; set; }
}
