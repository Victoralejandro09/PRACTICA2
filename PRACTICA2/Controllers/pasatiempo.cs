using Microsoft.AspNetCore.Mvc;
using PRACTICA2.Models;

namespace PRACTICA2.Controllers
{
    public class pasatiempo : Controller
    {
        public ActionResult Index()
        {
            List<string> hobbies = new List<string>
            {
                "Jugar videoJuegos",
                "Jugar Basketball",
                "Dormir"
            };

            return View(hobbies);
        }

        public ActionResult vparcial_artista()
        {
            List<Artista> artistas = new List<Artista>
    {
        new Artista
        {
            Imagen = "https://media.pitchfork.com/photos/655660797b11326f1ef9d338/4:3/w_1332,h_999,c_limit/TPR%20Header%20Bad%20Bunny.jpg",
            Nombre = "Bad Bunny",
            Resumen = " es un cantante, compositor, productor discográfico y luchador puertorriqueño. Caracterizado por su entonación grave, sus estilos musicales son generalmente definidos como reguetón y trap latino.",
            canciones = new List<string> { "callaita", "vete", "dakiti", "Ella perrea sola", "Mia" },
            Enlace = "https://es.wikipedia.org/wiki/Bad_Bunny"
        },
    new Artista
        {
            Imagen = "https://s2.abcstatics.com/abc/www/multimedia/play/2024/02/27/eladio-carrion-kalF-U6013832163559HI-1200x840@diario_abc.jpg",
            Nombre = "Eladio Carrion",
            Resumen = "Su carrera musical profesional comenzó en 2015. Sin embargo, tiempo antes ya era conocido como influencer en Puerto Rico haciendo parodias imitando las voces de artistas como Arcángel, Ñejo, Cosculluela, entre otros. ",
            canciones = new List<string> { "La cancion feliz del disco", "thunder", "TQMQA", "MBAPPE", "No te deseo el mal" },
            Enlace = "https://es.wikipedia.org/wiki/Eladio_Carri%C3%B3n"
        },
        new Artista
        {
            Imagen = "https://imagenes.20minutos.es/files/image_1920_1080/uploads/imagenes/2023/10/26/li_dinero-gana-feid-youtube-spotify.jpeg",
            Nombre = "Feid",
            Resumen = "Salomón Villada Hoyos​ (Suan, 19 de agosto de 1992), más conocido como Feid o Ferxxo,​ es un cantante, compositor y productor discográfico colombiano nacido en Suan, Atlántico.",
            canciones = new List<string> { "Luna", "yandel 150", "la inocente", "ultra solo", "feliz cumple" },
            Enlace = "https://es.wikipedia.org/wiki/Feid"
        }
    };

            return View(artistas);
        }

    }
}