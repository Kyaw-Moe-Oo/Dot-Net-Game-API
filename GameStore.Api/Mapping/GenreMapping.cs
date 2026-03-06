using System;
using GameStore.Api.Dtos;
using GameStore.Api.Entities;

namespace GameStore.Api.Mapping;

public static class GenreMapping
{
    public static GenreDto ToDto(this Genre genre)
    {
        // if (genre == null) throw new ArgumentNullException(nameof(genre));

        return new GenreDto(genre.Id, genre.Name);
    }
}
