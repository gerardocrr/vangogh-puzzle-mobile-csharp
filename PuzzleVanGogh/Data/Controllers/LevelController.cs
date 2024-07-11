using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleVanGogh.Data.Controllers
{
    public class LevelController
    {
        public void TwoImages(ref string botonclick, ref string boton1, ref string boton2)
        {
            if (boton1 == "img/black.webp")
            {
                boton1 = botonclick;
                botonclick = "img/black.webp";
            }
            else if (boton2 == "img/black.webp")
            {
                boton2 = botonclick;
                botonclick = "img/black.webp";
            }
        }

        public void ThreeImages(ref string botonclick, ref string boton1, ref string boton2, ref string boton3)
        {
            if (boton1 == "img/black.webp")
            {
                boton1 = botonclick;
                botonclick = "img/black.webp";
            }
            else if (boton2 == "img/black.webp")
            {
                boton2 = botonclick;
                botonclick = "img/black.webp";
            }
            else if (boton3 == "img/black.webp")
            {
                boton3 = botonclick;
                botonclick = "img/black.webp";
            }
        }
        public void FourImages(ref string botonclick, ref string boton1, ref string boton2, ref string boton3, ref string boton4)
        {
            if (boton1 == "img/black.webp")
            {
                boton1 = botonclick;
                botonclick = "img/black.webp";
            }
            else if (boton2 == "img/black.webp")
            {
                boton2 = botonclick;
                botonclick = "img/black.webp";
            }
            else if (boton3 == "img/black.webp")
            {
                boton3 = botonclick;
                botonclick = "img/black.webp";
            }
            else if (boton4 == "img/black.webp")
            {
                boton4 = botonclick;
                botonclick = "img/black.webp";
            }
        }

        //////////////Starry Night//////////////        

        public void ShuffleStarryNight(ref string path1, ref string path2, ref string path3, ref string path4, ref string path5, ref string path6, ref string path7, ref string path8, ref string path9)
        {
            string[] paths = { "img/black.webp", "img/starry-night/starry-night_1.webp", "img/starry-night/starry-night_2.webp", "img/starry-night/starry-night_3.webp", "img/starry-night/starry-night_4.webp", "img/starry-night/starry-night_5.webp", "img/starry-night/starry-night_6.webp", "img/starry-night/starry-night_7.webp", "img/starry-night/starry-night_8.webp" };
            Random rnd = new Random();
            paths = paths.OrderBy(x => rnd.Next()).ToArray();
            path1 = paths[0].ToString();
            path2 = paths[1].ToString();
            path3 = paths[2].ToString();
            path4 = paths[3].ToString();
            path5 = paths[4].ToString();
            path6 = paths[5].ToString();
            path7 = paths[6].ToString();
            path8 = paths[7].ToString();
            path9 = paths[8].ToString();
        }

        //////////////Self Portrait//////////////        

        public void ShuffleSelfPortrait(ref string path1, ref string path2, ref string path3, ref string path4, ref string path5, ref string path6, ref string path7, ref string path8, ref string path9)
        {
            string[] paths = { "img/black.webp", "img/self-portrait/self-portrait_1.webp", "img/self-portrait/self-portrait_2.webp", "img/self-portrait/self-portrait_3.webp", "img/self-portrait/self-portrait_4.webp", "img/self-portrait/self-portrait_5.webp", "img/self-portrait/self-portrait_6.webp", "img/self-portrait/self-portrait_7.webp", "img/self-portrait/self-portrait_8.webp" };
            Random rnd = new Random();
            paths = paths.OrderBy(x => rnd.Next()).ToArray();
            path1 = paths[0].ToString();
            path2 = paths[1].ToString();
            path3 = paths[2].ToString();
            path4 = paths[3].ToString();
            path5 = paths[4].ToString();
            path6 = paths[5].ToString();
            path7 = paths[6].ToString();
            path8 = paths[7].ToString();
            path9 = paths[8].ToString();
        }

        //////////////Almond Blossom//////////////

        public void ShuffleAlmondBlossom(ref string path1, ref string path2, ref string path3, ref string path4, ref string path5, ref string path6, ref string path7, ref string path8, ref string path9)
        {
            string[] paths = { "img/black.webp", "img/almond-blossom/almond-blossom_1.webp", "img/almond-blossom/almond-blossom_2.webp", "img/almond-blossom/almond-blossom_3.webp", "img/almond-blossom/almond-blossom_4.webp", "img/almond-blossom/almond-blossom_5.webp", "img/almond-blossom/almond-blossom_6.webp", "img/almond-blossom/almond-blossom_7.webp", "img/almond-blossom/almond-blossom_8.webp" };
            Random rnd = new Random();
            paths = paths.OrderBy(x => rnd.Next()).ToArray();
            path1 = paths[0].ToString();
            path2 = paths[1].ToString();
            path3 = paths[2].ToString();
            path4 = paths[3].ToString();
            path5 = paths[4].ToString();
            path6 = paths[5].ToString();
            path7 = paths[6].ToString();
            path8 = paths[7].ToString();
            path9 = paths[8].ToString();
        }

        //////////////Round Prisioners//////////////

        public void ShuffleRoundPrisoners(ref string path1, ref string path2, ref string path3, ref string path4, ref string path5, ref string path6, ref string path7, ref string path8, ref string path9)
        {
            string[] paths = { "img/black.webp", "img/round-prisoners/round-prisoners_1.webp", "img/round-prisoners/round-prisoners_2.webp", "img/round-prisoners/round-prisoners_3.webp", "img/round-prisoners/round-prisoners_4.webp", "img/round-prisoners/round-prisoners_5.webp", "img/round-prisoners/round-prisoners_6.webp", "img/round-prisoners/round-prisoners_7.webp", "img/round-prisoners/round-prisoners_8.webp" };
            Random rnd = new Random();
            paths = paths.OrderBy(x => rnd.Next()).ToArray();
            path1 = paths[0].ToString();
            path2 = paths[1].ToString();
            path3 = paths[2].ToString();
            path4 = paths[3].ToString();
            path5 = paths[4].ToString();
            path6 = paths[5].ToString();
            path7 = paths[6].ToString();
            path8 = paths[7].ToString();
            path9 = paths[8].ToString();
        }

        //////////////Skeleton Head//////////////

        public void ShuffleSkeletonHead(ref string path1, ref string path2, ref string path3, ref string path4, ref string path5, ref string path6, ref string path7, ref string path8, ref string path9)
        {
            string[] paths = { "img/black.webp", "img/skeleton-head/skeleton-head_1.webp", "img/skeleton-head/skeleton-head_2.webp", "img/skeleton-head/skeleton-head_3.webp", "img/skeleton-head/skeleton-head_4.webp", "img/skeleton-head/skeleton-head_5.webp", "img/skeleton-head/skeleton-head_6.webp", "img/skeleton-head/skeleton-head_7.webp", "img/skeleton-head/skeleton-head_8.webp" };
            Random rnd = new Random();
            paths = paths.OrderBy(x => rnd.Next()).ToArray();
            path1 = paths[0].ToString();
            path2 = paths[1].ToString();
            path3 = paths[2].ToString();
            path4 = paths[3].ToString();
            path5 = paths[4].ToString();
            path6 = paths[5].ToString();
            path7 = paths[6].ToString();
            path8 = paths[7].ToString();
            path9 = paths[8].ToString();
        }

        //////////////Potato Eaters//////////////

        public void ShufflePotatoEaters(ref string path1, ref string path2, ref string path3, ref string path4, ref string path5, ref string path6, ref string path7, ref string path8, ref string path9)
        {
            string[] paths = { "img/black.webp", "img/potato-eaters/potato-eaters_1.webp", "img/potato-eaters/potato-eaters_2.webp", "img/potato-eaters/potato-eaters_3.webp", "img/potato-eaters/potato-eaters_4.webp", "img/potato-eaters/potato-eaters_5.webp", "img/potato-eaters/potato-eaters_6.webp", "img/potato-eaters/potato-eaters_7.webp", "img/potato-eaters/potato-eaters_8.webp" };
            Random rnd = new Random();
            paths = paths.OrderBy(x => rnd.Next()).ToArray();
            path1 = paths[0].ToString();
            path2 = paths[1].ToString();
            path3 = paths[2].ToString();
            path4 = paths[3].ToString();
            path5 = paths[4].ToString();
            path6 = paths[5].ToString();
            path7 = paths[6].ToString();
            path8 = paths[7].ToString();
            path9 = paths[8].ToString();
        }
    }
}
