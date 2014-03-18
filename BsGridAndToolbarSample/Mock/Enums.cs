using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyGrid.Mock
{
    public enum MovieGenre
    {
        Action = 1,
        Adventure = 2,
        Animation = 3,
        Biography = 4,
        Comedy = 5,
        Crime = 6,
        Documentary = 7,
        Drama = 8,
        Family = 9,
        Fantasy = 10,
        [Display(Name = "Film-Noir")]
        FilmNoir = 11,
        History = 12,
        Horror = 13,
        Music = 14,
        Musical = 15,
        Mystery = 16,
        Romance = 17,
        [Display(Name = "Sci-Fi")]
        SciFi = 18,
        Short = 19,
        Sport = 20,
        Thriller = 21,
        War = 22,
        Western = 23
    }

    public enum YesNoValueTypes
    {
        [Display(Name = "All")]
        Both = 1,
        [Display(Name = "Yes")]
        Yes = 2,
        [Display(Name = "No")]
        No = 3,
    }
}