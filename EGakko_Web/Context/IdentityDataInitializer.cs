using EGakko_DAL.Data;
using EGakko_Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EGakko_Web.Context
{
    public class IdentityDataInitializer
    {

        public static async Task SeedIdentityUsers(UserManager<CustomUser> userManager, RoleManager<IdentityRole> roleManager, ApplicationDbContext applicationDbContext)
        {

            if (userManager.Users.Count() > 0)
                return;

            List<CustomUser> customUserTeacher = new List<CustomUser>
            {
                new CustomUser {
                    Email = "mbritten0@msn.com",
                    FName = "Marty",
                    LName = "Britten",
                    Street = "Sunnyside",
                    HouseNumber = 9,
                    ZipCode = "19-101",
                    City = "Mońki",
                    BirthDate = new DateTime(1991,05,13),Gender = (Gender)1},
                new CustomUser {
                    Email = "hcroot1@bbc.co.uk",
                    FName = "Paula",
                    LName = "Croot",
                    Street = "Nevada",
                    HouseNumber = 7,
                    ZipCode = "CB4",
                    City = "Church End",
                    BirthDate = new DateTime(1981,12,13),Gender = (Gender)1},
                new CustomUser {
                    Email = "lwarby2@abc.net.au",
                    FName = "Scooby",
                    LName = "Warby",
                    Street = "Luster",
                    HouseNumber = 70,
                    ZipCode = "59347-000",
                    City = "Ouro Branco",
                    BirthDate = new DateTime(1989,02,26),Gender = (Gender)0},
                new CustomUser {
                    Email = "dlaydel3@pen.io",
                    FName = "Daniëla",
                    LName = "Laydel",
                    Street = "Butterfield",
                    HouseNumber = 304,
                    ZipCode = null,
                    City = "Bayan Hure",
                    BirthDate = new DateTime(1995,11,16),Gender = (Gender)1},
                new CustomUser {
                    Email = "bborsay4@rambler.ru",
                    FName = "Jabari",
                    LName = "Borsay",
                    Street = "Coolidge",
                    HouseNumber = 9068,
                    ZipCode = null,
                    City = "Xiluodu",
                    BirthDate = new DateTime(1985,1,18),Gender =(Gender)0}
            };
            List<CustomUser> customUserStudent = new List<CustomUser>
                {
                new CustomUser
                    {
                        Email= "lcollingwood19@freewebs.com",
                        FName= "Loraine",
                        LName= "Collingwood",
                        Street= "Randy",
                        HouseNumber= 2169,
                        ZipCode= "4755,484",
                        City= "Rio Covo ( Santa Eulália )",
                        BirthDate= new DateTime(2001,12,25),
                        Gender= (Gender)1
                    },
                new CustomUser
                    {
                        Email= "asudworth1a@blogs.com",
                        FName= "Alex",
                        LName= "Sudworth",
                        Street= "Carberry",
                        HouseNumber= 629,
                        ZipCode= null,
                        City= "Zhongzhou",
                        BirthDate= new DateTime(2001,12,18),
                        Gender= 0
                    },
                new CustomUser
                    {
                        Email= "pwalcot1b@pen.io",
                        FName= "Phillip",
                        LName= "Walcot",
                        Street= "Stuart",
                        HouseNumber= 3,
                        ZipCode= null,
                        City= "Tadabliro",
                        BirthDate= new DateTime(2001,10,2),
                        Gender= 0
                    },
                new CustomUser
                    {
                        Email= "ksqueers1c@wunderground.com",
                        FName= "Kirbie",
                        LName= "Squeers",
                        Street= "Graedel",
                        HouseNumber= 8068,
                        ZipCode= null,
                        City= "Machang",
                        BirthDate= new DateTime(2001,12,10),
                        Gender= (Gender)1
                    },
                new CustomUser
                    {
                        Email= "bemerton1d@dailymotion.com",
                        FName= "Berne",
                        LName= "Emerton",
                        Street= "Graceland",
                        HouseNumber= 1,
                        ZipCode= null,
                        City= "Yogyakarta",
                        BirthDate= new DateTime(2001,8,3),
                        Gender= 0
                    },
                new CustomUser
                    {
                        Email= "tphelipeau1e@opensource.org",
                        FName= "Tudor",
                        LName= "Phelipeau",
                        Street= "Briar Crest",
                        HouseNumber= 8,
                        ZipCode= "6052",
                        City= "Patao",
                        BirthDate= new DateTime(2001,5,17),
                        Gender= 0
                    },
                new CustomUser
                    {
                        Email= "gzealander1f@spiegel.de",
                        FName= "Georgie",
                        LName= "Zealander",
                        Street= "Portage",
                        HouseNumber= 102,
                        ZipCode= null,
                        City= "Bedayutalang",
                        BirthDate= new DateTime(2001,4,7),
                        Gender= 0
                    },
                new CustomUser
                    {
                        Email= "maubery1g@accuweather.com",
                        FName= "Moreen",
                        LName= "Aubery",
                        Street= "Vera",
                        HouseNumber= 4,
                        ZipCode= null,
                        City= "Sembabule",
                        BirthDate= new DateTime(2001,02,25),
                        Gender= (Gender)1
                    },
                new CustomUser
                    {
                        Email= "wsaleway1h@flavors.me",
                        FName= "Web",
                        LName= "Saleway",
                        Street= "Spaight",
                        HouseNumber= 52835,
                        ZipCode= "157510",
                        City= "Vetluzhskiy",
                        BirthDate= new DateTime(2001,4,01),
                        Gender= 0
                    },
                new CustomUser
                    {
                        Email= "jcutridge1i@sohu.com",
                        FName= "Janette",
                        LName= "Cutridge",
                        Street= "7th",
                        HouseNumber= 992,
                        ZipCode= "4630,025",
                        City= "Currais",
                        BirthDate= new DateTime(2001,2,12),
                        Gender= (Gender)1
                    },
                new CustomUser
                    {
                        Email= "medler1j@home.pl",
                        FName= "Mort",
                        LName= "Edler",
                        Street= "Loomis",
                        HouseNumber= 960,
                        ZipCode= "9217",
                        City= "Pañgobilian",
                        BirthDate= new DateTime(2001,1,15),
                        Gender= 0
                    },
                new CustomUser
                    {
                        Email= "seliaz1k@nasa.gov",
                        FName= "Saunderson",
                        LName= "Eliaz",
                        Street= "Daystar",
                        HouseNumber= 235,
                        ZipCode= "8513",
                        City= "Esperanza",
                        BirthDate= new DateTime(2001,5,22),
                        Gender= 0
                    },
                new CustomUser
                    {
                        Email= "lunthank1l@timesonline.co.uk",
                        FName= "Luci",
                        LName= "Unthank",
                        Street= "Surrey",
                        HouseNumber= 87,
                        ZipCode= null,
                        City= "Alexandria",
                        BirthDate= new DateTime(2001,8,17),
                        Gender= (Gender)1
                    },
                new CustomUser
                    {
                        Email= "bmoreman1m@wp.com",
                        FName= "Bard",
                        LName= "Moreman",
                        Street= "Farwell",
                        HouseNumber= 54340,
                        ZipCode= "3402",
                        City= "Saguday",
                        BirthDate= new DateTime(2001,3,07),
                        Gender= 0
                    },
                new CustomUser
                    {
                        Email= "ostorre1n@clickbank.net",
                        FName= "Onfroi",
                        LName= "Storre",
                        Street= "Sloan",
                        HouseNumber= 14105,
                        ZipCode= null,
                        City= "Owerri",
                        BirthDate= new DateTime(2001,11,19),
                        Gender= 0
                    },
                new CustomUser
                    {
                        Email= "ybrine1o@indiegogo.com",
                        FName= "Yancy",
                        LName= "Brine",
                        Street= "Surrey",
                        HouseNumber= 96,
                        ZipCode= "67130",
                        City= "Wichian Buri",
                        BirthDate= new DateTime(2001,7,19),
                        Gender= 0
                    },
                new CustomUser
                    {
                        Email= "pbrewin1p@sitemeter.com",
                        FName= "Pierrette",
                        LName= "Brewin",
                        Street= "Lotheville",
                        HouseNumber= 91,
                        ZipCode= null,
                        City= "Kostanay",
                        BirthDate= new DateTime(2001,9,10),
                        Gender= (Gender)1
                    },
                new CustomUser
                    {
                        Email= "jkerrod1q@mtv.com",
                        FName= "Josias",
                        LName= "Kerrod",
                        Street= "Cascade",
                        HouseNumber= 8,
                        ZipCode= null,
                        City= "Xizhong",
                        BirthDate= new DateTime(2001,7,31),
                        Gender= 0
                    },
                new CustomUser
                    {
                        Email= "erenfree1r@kickstarter.com",
                        FName= "Erie",
                        LName= "Renfree",
                        Street= "Division",
                        HouseNumber= 1,
                        ZipCode= null,
                        City= "Henggang",
                        BirthDate= new DateTime(2001,11,20),
                        Gender= 0
                    },
                new CustomUser
                    {
                        Email= "btallet1s@nymag.com",
                        FName= "Blondy",
                        LName= "Tallet",
                        Street= "Eggendart",
                        HouseNumber= 98,
                        ZipCode= null,
                        City= "Yihe",
                        BirthDate= new DateTime(2001,11,22),
                        Gender= (Gender)1
                    },
                new CustomUser
                    {
                        Email= "thawgood1t@wiley.com",
                        FName= "Tobe",
                        LName= "Hawgood",
                        Street= "Beilfuss",
                        HouseNumber= 525,
                        ZipCode= null,
                        City= "Karuk",
                        BirthDate= new DateTime(2001,7,29),
                        Gender= (Gender)1
                    },
                new CustomUser
                    {
                        Email= "wdalwis1u@opera.com",
                        FName= "Whitaker",
                        LName= "D'Alwis",
                        Street= "Loomis",
                        HouseNumber= 71,
                        ZipCode= null,
                        City= "Xiting",
                        BirthDate= new DateTime(2001,4,29),
                        Gender= 0
                    },


                new CustomUser
                    {
                        Email= "mcorriea0@goo.gl",
                        FName= "Mathe",
                        LName= "Corriea",
                        Street= "Mariners Cove",
                        HouseNumber= 2,
                        ZipCode= null,
                        City= "Anjozorobe",
                        BirthDate= new DateTime(2002,7,10),
                        Gender= 0
                    },
                new CustomUser
                    {
                        Email= "barne1@mac.com",
                        FName= "Buck",
                        LName= "Arne",
                        Street= "Wayridge",
                        HouseNumber= 43644,
                        ZipCode= null,
                        City= "Požarevac",
                        BirthDate= new DateTime(2002,2,09),
                        Gender= 0
                    },
                new CustomUser
                    {
                        Email= "bzmitrovich2@livejournal.com",
                        FName= "Brett",
                        LName= "Zmitrovich",
                        Street= "Melby",
                        HouseNumber= 8646,
                        ZipCode= "19360,000",
                        City= "Santo Anastácio",
                        BirthDate= new DateTime(2002,10,07),
                        Gender= 0
                    },
                new CustomUser
                    {
                        Email= "jlerwell3@aol.com",
                        FName= "Junette",
                        LName= "Lerwell",
                        Street= "Scott",
                        HouseNumber= 51,
                        ZipCode= null,
                        City= "Tucheng",
                        BirthDate= new DateTime(2002,8,26),
                        Gender= (Gender)1
                    },
                new CustomUser
                    {
                        Email= "ebottoner4@un.org",
                        FName= "Eleonore",
                        LName= "Bottoner",
                        Street= "Larry",
                        HouseNumber= 37,
                        ZipCode= "4706",
                        City= "Bulan",
                        BirthDate= new DateTime(2002,3,11),
                        Gender= (Gender)1
                    },
                new CustomUser
                    {
                        Email= "obartoszewski5@sina.com.cn",
                        FName= "Ogden",
                        LName= "Bartoszewski",
                        Street= "Maryland",
                        HouseNumber= 7,
                        ZipCode= "243240",
                        City= "Starodub",
                        BirthDate= new DateTime(2002,10,21),
                        Gender= 0
                    },
                new CustomUser
                    {
                        Email= "pscutter6@usgs.gov",
                        FName= "Pegeen",
                        LName= "Scutter",
                        Street= "Melvin",
                        HouseNumber= 5,
                        ZipCode= null,
                        City= "Siak Sri Indrapura",
                        BirthDate= new DateTime(2002,9,15),
                        Gender= (Gender)1
                    },
                new CustomUser
                    {
                        Email= "cpreddle7@ezinearticles.com",
                        FName= "Carson",
                        LName= "Preddle",
                        Street= "Claremont",
                        HouseNumber= 8128,
                        ZipCode= "277 03",
                        City= "Horní Počaply",
                        BirthDate= new DateTime(2002,3,27),
                        Gender= 0
                    },
                new CustomUser
                    {
                        Email= "achilton8@time.com",
                        FName= "Alvy",
                        LName= "Chilton",
                        Street= "Eggendart",
                        HouseNumber= 379,
                        ZipCode= null,
                        City= "Kahama",
                        BirthDate= new DateTime(2002,10,26),
                        Gender= 0
                    },
                new CustomUser
                    {
                        Email= "yblincoe9@tamu.edu",
                        FName= "Yelena",
                        LName= "Blincoe",
                        Street= "Merry",
                        HouseNumber= 81489,
                        ZipCode= null,
                        City= "San José de Río Tinto",
                        BirthDate= new DateTime(2002,11,22),
                        Gender= (Gender)1
                    },
                new CustomUser
                    {
                        Email= "rhampshawa@chronoengine.com",
                        FName= "Roger",
                        LName= "Hampshaw",
                        Street= "Sommers",
                        HouseNumber= 4642,
                        ZipCode= null,
                        City= "Bijeli",
                        BirthDate= new DateTime(2002,4,26),
                        Gender= 0
                    },
                new CustomUser
                    {
                        Email= "vpoleyb@vk.com",
                        FName= "Vivia",
                        LName= "Poley",
                        Street= "Dryden",
                        HouseNumber= 60,
                        ZipCode= null,
                        City= "Maţāy",
                        BirthDate= new DateTime(2002,9,04),
                        Gender= (Gender)1
                    },
                new CustomUser
                    {
                        Email= "ageanyc@fc2.com",
                        FName= "Alvera",
                        LName= "Geany",
                        Street= "Hooker",
                        HouseNumber= 50654,
                        ZipCode= "07800",
                        City= "Lapinjärvi",
                        BirthDate= new DateTime(2002,9,10),
                        Gender= (Gender)1
                    },
                new CustomUser
                    {
                        Email= "reveralld@vimeo.com",
                        FName= "Rozina",
                        LName= "Everall",
                        Street= "Old Shore",
                        HouseNumber= 409,
                        ZipCode= "03005",
                        City= "Alicante/Alacant",
                        BirthDate= new DateTime(2002,8,27),
                        Gender= (Gender)1
                    },
                new CustomUser
                    {
                        Email= "jbutlere@gravatar.com",
                        FName= "Jammie",
                        LName= "Butler",
                        Street= "Prairieview",
                        HouseNumber= 7,
                        ZipCode= "92511 CEDEX",
                        City= "Boulogne,Billancourt",
                        BirthDate= new DateTime(2002,9,20),
                        Gender= (Gender)1
                    },
                new CustomUser
                    {
                        Email= "ahoundsomf@ed.gov",
                        FName= "Anderson",
                        LName= "Houndsom",
                        Street= "West",
                        HouseNumber= 4,
                        ZipCode= null,
                        City= "Myingyan",
                        BirthDate= new DateTime(2002,7,9),
                        Gender= 0
                    },
                new CustomUser
                    {
                        Email= "blilloeg@intel.com",
                        FName= "Beau",
                        LName= "Lilloe",
                        Street= "Caliangt",
                        HouseNumber= 3,
                        ZipCode= null,
                        City= "Vilque Chico",
                        BirthDate= new DateTime(2002,5,14),
                        Gender= 0
                    },
                new CustomUser
                    {
                        Email= "vshrievesh@hud.gov",
                        FName= "Vasilis",
                        LName= "Shrieves",
                        Street= "Wayridge",
                        HouseNumber= 76,
                        ZipCode= "2815,625",
                        City= "Sobreda",
                        BirthDate= new DateTime(2002,10,10),
                        Gender= 0
                    },
                new CustomUser
                    {
                        Email= "dwolstenholmei@stanford.edu",
                        FName= "Deni",
                        LName= "Wolstenholme",
                        Street= "Helena",
                        HouseNumber= 7,
                        ZipCode= null,
                        City= "Trostyanets’",
                        BirthDate= new DateTime(2002,9,11),
                        Gender= (Gender)1
                    },
                new CustomUser
                    {
                        Email= "dlodekej@youku.com",
                        FName= "Donetta",
                        LName= "Lodeke",
                        Street= "4th",
                        HouseNumber= 717,
                        ZipCode= "59652 CEDEX",
                        City= "Villeneuve,d'Ascq",
                        BirthDate= new DateTime(2002,5,25),
                        Gender= (Gender)1
                    },
                new CustomUser
                    {
                        Email= "velijahuk@fastcompany.com",
                        FName= "Valma",
                        LName= "Elijahu",
                        Street= "Harbort",
                        HouseNumber= 5,
                        ZipCode= "3005",
                        City= "Pulilan",
                        BirthDate= new DateTime(2002,10,19),
                        Gender= (Gender)1
                    },
                new CustomUser
                    {
                        Email= "nlethardyl@pagesperso,orange.fr",
                        FName= "Nathan",
                        LName= "Lethardy",
                        Street= "Lukken",
                        HouseNumber= 33601,
                        ZipCode= "94636 CEDEX 1",
                        City= "Rungis",
                        BirthDate= new DateTime(2002,2,13),
                        Gender= 0
                    },
                new CustomUser
                    {
                        Email= "khassonm@dailymotion.com",
                        FName= "Kitti",
                        LName= "Hasson",
                        Street= "Melrose",
                        HouseNumber= 4948,
                        ZipCode= null,
                        City= "Mangochi",
                        BirthDate= new DateTime(2002,5,26),
                        Gender= (Gender)1
                    },
                new CustomUser
                    {
                        Email= "bvanderveldtn@devhub.com",
                        FName= "Binky",
                        LName= "Van der Veldt",
                        Street= "Bartelt",
                        HouseNumber= 46828,
                        ZipCode= null,
                        City= "Baardheere",
                        BirthDate= new DateTime(2002,12,18),
                        Gender= 0
                    },
                new CustomUser
                    {
                        Email= "lskotchero@paypal.com",
                        FName= "Letitia",
                        LName= "Skotcher",
                        Street= "Buell",
                        HouseNumber= 5,
                        ZipCode= "428902",
                        City= "Troitsk",
                        BirthDate= new DateTime(2002,3,4),
                        Gender= (Gender)1
                    },


                new CustomUser
{
    Email= "hligertwoodp@rambler.ru",
    FName= "Hi",
    LName= "Ligertwood",
    Street= "Dawn",
    HouseNumber= 274,
    ZipCode= "43131",
    City= "San Antonio",
    BirthDate= new DateTime(2003,11,16),
    Gender= 0
},
                new CustomUser
{
    Email= "mveigheyq@indiatimes.com",
    FName= "Mead",
    LName= "Veighey",
    Street= "Coleman",
    HouseNumber= 8,
    ZipCode= null,
    City= "Xixia",
    BirthDate= new DateTime(2003,3,5),
    Gender= 0
},
                new CustomUser
{
    Email= "gforstr@abc.net.au",
    FName= "Gaby",
    LName= "Forst",
    Street= "Acker",
    HouseNumber= 7,
    ZipCode= null,
    City= "Wuping",
    BirthDate= new DateTime(2003,2,21),
    Gender= (Gender)1
},
                new CustomUser
{
    Email= "mtollands@statcounter.com",
    FName= "Mord",
    LName= "Tolland",
    Street= "Northview",
    HouseNumber= 509,
    ZipCode= "872 24",
    City= "Kramfors",
    BirthDate= new DateTime(2003,8,10),
    Gender= 0
},
                new CustomUser
{
    Email= "rjowerst@lycos.com",
    FName= "Rhoda",
    LName= "Jowers",
    Street= "Moose",
    HouseNumber= 0,
    ZipCode= "8130",
    City= "Kesabpur",
    BirthDate= new DateTime(2003,6,7),
    Gender= (Gender)1
},
                new CustomUser
{
    Email= "ebruckmannu@wordpress.com",
    FName= "Eustace",
    LName= "Bruckmann",
    Street= "New Castle",
    HouseNumber= 52565,
    ZipCode= "65665,000",
    City= "São João dos Patos",
    BirthDate= new DateTime(2003,8,20),
    Gender= 0
},
                new CustomUser
{
    Email= "lvegasv@ted.com",
    FName= "Lian",
    LName= "Vegas",
    Street= "Debs",
    HouseNumber= 40256,
    ZipCode= null,
    City= "Guotan",
    BirthDate= new DateTime(2003,8,26),
    Gender= (Gender)1
},
                new CustomUser
{
    Email= "brunseyw@wsj.com",
    FName= "Barnabas",
    LName= "Runsey",
    Street= "Pond",
    HouseNumber= 34090,
    ZipCode= null,
    City= "Mpika",
    BirthDate= new DateTime(2003,5,5),
    Gender= 0
},
                new CustomUser
{
    Email= "crugierix@fda.gov",
    FName= "Cece",
    LName= "Rugieri",
    Street= "Milwaukee",
    HouseNumber= 43,
    ZipCode= "626,0077",
    City= "Miyazu",
    BirthDate= new DateTime(2003,2,2),
    Gender= 0
},
                new CustomUser
{
    Email= "kmcilhattony@ucoz.ru",
    FName= "Kristofor",
    LName= "McIlhatton",
    Street= "Mallard",
    HouseNumber= 874,
    ZipCode= null,
    City= "Krajanbonjor",
    BirthDate= new DateTime(2003,4,6),
    Gender= 0
},
                new CustomUser
{
    Email= "anylesz@nifty.com",
    FName= "Al",
    LName= "Nyles",
    Street= "Susan",
    HouseNumber= 15,
    ZipCode= "58300,000",
    City= "Santa Rita",
    BirthDate= new DateTime(2003,1,22),
    Gender= 0
},
                new CustomUser
{
    Email= "hsholem10@who.int",
    FName= "Howey",
    LName= "Sholem",
    Street= "Canary",
    HouseNumber= 60183,
    ZipCode= "31000",
    City= "Phak Hai",
    BirthDate= new DateTime(2003,3,13),
    Gender= 0
},
                new CustomUser
{
    Email= "bbanasiak11@nytimes.com",
    FName= "Bambie",
    LName= "Banasiak",
    Street= "Anzinger",
    HouseNumber= 09,
    ZipCode= "6594",
    City= "Momignies",
    BirthDate= new DateTime(2003,6,24),
    Gender= (Gender)1
},
                new CustomUser
{
    Email= "jmouland12@dmoz.org",
    FName= "Jeremias",
    LName= "Mouland",
    Street= "Tony",
    HouseNumber= 448,
    ZipCode= null,
    City= "San Casimiro",
    BirthDate= new DateTime(2003,1,20),
    Gender= 0
},
                new CustomUser
{
    Email= "kjoice13@e,recht24.de",
    FName= "Kalil",
    LName= "Joice",
    Street= "Eastwood",
    HouseNumber= 87,
    ZipCode= null,
    City= "Kedian",
    BirthDate= new DateTime(2003,11,15),
    Gender= 0
},
                new CustomUser
{
    Email= "wvalentinetti14@de.vu",
    FName= "Wendel",
    LName= "Valentinetti",
    Street= "Bluestem",
    HouseNumber= 3393,
    ZipCode= "641 47",
    City= "Katrineholm",
    BirthDate= new DateTime(2003,2,6),
    Gender= 0
},
                new CustomUser
{
    Email= "pkesby15@marketwatch.com",
    FName= "Peyter",
    LName= "Kesby",
    Street= "Spaight",
    HouseNumber= 73,
    ZipCode= null,
    City= "Tangkolo",
    BirthDate= new DateTime(2003,4,5),
    Gender= 0
},
                new CustomUser
{
    Email= "emarfell16@mapy.cz",
    FName= "Evelyn",
    LName= "Marfell",
    Street= "Banding",
    HouseNumber= 94337,
    ZipCode= null,
    City= "Lamalera",
    BirthDate= new DateTime(2003,7,1),
    Gender= (Gender)1
},
                new CustomUser
{
    Email= "wbrigstock17@hugedomains.com",
    FName= "Winna",
    LName= "Brigstock",
    Street= "Eagle Crest",
    HouseNumber= 15,
    ZipCode= null,
    City= "Mỏ Cày",
    BirthDate= new DateTime(2003,1,8),
    Gender= (Gender)1
},
                new CustomUser
{
    Email= "bbills18@ning.com",
    FName= "Benton",
    LName= "Bills",
    Street= "Northfield",
    HouseNumber= 757,
    ZipCode= null,
    City= "Pavliš",
    BirthDate= new DateTime(2003,10,28),
    Gender= 0
},

           
                new CustomUser
                    {
                        Email= "nfrediani1v@spiegel.de",
                        FName= "Neville",
                        LName= "Frediani",
                        Street= "Erie",
                        HouseNumber= 00713,
                        ZipCode= "646760",
                        City= "Pavlogradka",
                        BirthDate= new DateTime(2004,9,3),
                        Gender= 0
                    },
                new CustomUser
                    {
                        Email= "fwilshire1w@furl.net",
                        FName= "Falkner",
                        LName= "Wilshire",
                        Street= "Katie",
                        HouseNumber= 81924,
                        ZipCode= null,
                        City= "Capacmarca",
                        BirthDate= new DateTime(2004,4,24),
                        Gender= 0
                    },
                new CustomUser
                    {
                        Email= "krolfs1x@wp.com",
                        FName= "Karon",
                        LName= "Rolfs",
                        Street= "Grim",
                        HouseNumber= 72594,
                        ZipCode= "641960",
                        City= "Shatrovo",
                        BirthDate= new DateTime(2004,4,13),
                        Gender= (Gender)1
                    },
                new CustomUser
                    {
                        Email= "plearoid1y@flavors.me",
                        FName= "Patrick",
                        LName= "Learoid",
                        Street= "Stoughton",
                        HouseNumber= 2885,
                        ZipCode= null,
                        City= "Muqui",
                        BirthDate= new DateTime(2004,12,24),
                        Gender= 0
                    },
                new CustomUser
                    {
                        Email= "mroads1z@bravesites.com",
                        FName= "Maurie",
                        LName= "Roads",
                        Street= "Pepper Wood",
                        HouseNumber= 9,
                        ZipCode= "LS6",
                        City= "Leeds",
                        BirthDate= new DateTime(2004,4,06),
                        Gender= 0
                    },
                new CustomUser
                    {
                        Email= "fhalpen20@illinois.edu",
                        FName= "Florian",
                        LName= "Halpen",
                        Street= "Milwaukee",
                        HouseNumber= 8,
                        ZipCode= null,
                        City= "Haoping",
                        BirthDate= new DateTime(2004,7,08),
                        Gender= 0
                    },
                new CustomUser
                    {
                        Email= "eplum21@archive.org",
                        FName= "Emelina",
                        LName= "Plum",
                        Street= "Havey",
                        HouseNumber= 23,
                        ZipCode= null,
                        City= "Dioknisi",
                        BirthDate= new DateTime(2004,8,29),
                        Gender= (Gender)1
                    },
                new CustomUser
                    {
                        Email= "nbaldery22@google.co.jp",
                        FName= "Nathalie",
                        LName= "Baldery",
                        Street= "Merrick",
                        HouseNumber= 31502,
                        ZipCode= "5385",
                        City= "Las Higueras",
                        BirthDate= new DateTime(2004,10,03),
                        Gender= (Gender)1
                    },
                new CustomUser
                    {
                        Email= "ssmerdon23@odnoklassniki.ru",
                        FName= "Sullivan",
                        LName= "Smerdon",
                        Street= "Artisan",
                        HouseNumber= 0,
                        ZipCode= null,
                        City= "Mataguži",
                        BirthDate= new DateTime(2004,4,01),
                        Gender= 0
                    },
                new CustomUser
                    {
                        Email= "dmallall24@devhub.com",
                        FName= "Debbi",
                        LName= "Mallall",
                        Street= "Meadow Valley",
                        HouseNumber= 1,
                        ZipCode= null,
                        City= "Liulin",
                        BirthDate= new DateTime(2004,5,27),
                        Gender= (Gender)1
                    },
                new CustomUser
                    {
                        Email= "kcreigan25@scribd.com",
                        FName= "Kathy",
                        LName= "Creigan",
                        Street= "Pearson",
                        HouseNumber= 7,
                        ZipCode= "052038",
                        City= "Yarumal",
                        BirthDate= new DateTime(2004,2,13),
                        Gender= (Gender)1
                    },
                new CustomUser
                    {
                        Email= "cevason26@fda.gov",
                        FName= "Candie",
                        LName= "Evason",
                        Street= "Dahle",
                        HouseNumber= 7,
                        ZipCode= "904 35",
                        City= "Umeå",
                        BirthDate= new DateTime(2004,5,03),
                        Gender= (Gender)1
                    },
                new CustomUser
                    {
                        Email= "jsedgefield27@cdbaby.com",
                        FName= "Jimmie",
                        LName= "Sedgefield",
                        Street= "Rigney",
                        HouseNumber= 296,
                        ZipCode= null,
                        City= "Shazikou",
                        BirthDate= new DateTime(2004,4,16),
                        Gender= 0
                    },
                new CustomUser
                    {
                        Email= "lmathiasen28@marketwatch.com",
                        FName= "Leroy",
                        LName= "Mathiasen",
                        Street= "Hooker",
                        HouseNumber= 801,
                        ZipCode= null,
                        City= "Bulgan",
                        BirthDate= new DateTime(2004,8,26),
                        Gender= 0
                    },
                new CustomUser
                    {
                        Email= "tborzone29@utexas.edu",
                        FName= "Tammy",
                        LName= "Borzone",
                        Street= "Mitchell",
                        HouseNumber= 26010,
                        ZipCode= null,
                        City= "Shataping",
                        BirthDate= new DateTime(2004,8,24),
                        Gender= (Gender)1
                    },
                new CustomUser
                    {
                        Email= "ttrattles2a@spiegel.de",
                        FName= "Teddie",
                        LName= "Trattles",
                        Street= "Luster",
                        HouseNumber= 692,
                        ZipCode= null,
                        City= "Lalukoen Dua",
                        BirthDate= new DateTime(2004,3,22),
                        Gender= (Gender)1
                    },
                new CustomUser
                    {
                        Email= "welnor2b@usnews.com",
                        FName= "Wes",
                        LName= "Elnor",
                        Street= "3rd",
                        HouseNumber= 76,
                        ZipCode= null,
                        City= "Mariental",
                        BirthDate= new DateTime(2004,9,23),
                        Gender= 0
                    },
                new CustomUser
                    {
                        Email= "hfrapwell2c@oaic.gov.au",
                        FName= "Heather",
                        LName= "Frapwell",
                        Street= "Village",
                        HouseNumber= 968,
                        ZipCode= null,
                        City= "Jinchang",
                        BirthDate= new DateTime(2004,7,20),
                        Gender= (Gender)1
                    }
                };

            List<CustomUser> defaultUsers = new List<CustomUser>
            {
                          new CustomUser
                    {
                        Email= "gdunridge2d@europa.eu",
                        FName= "Gordy",
                        LName= "Dunridge",
                        Street= "Crowley",
                        HouseNumber= 8,
                        ZipCode= "9810",
                        City= "Bagumbayan",
                        BirthDate= new DateTime(2004,5,26),
                        Gender= 0
                    },
                new CustomUser
                    {
                        Email= "jirlam2e@shinystat.com",
                        FName= "Joletta",
                        LName= "Irlam",
                        Street= "Carey",
                        HouseNumber= 720,
                        ZipCode= null,
                        City= "Patos Fshat",
                        BirthDate= new DateTime(2004,9,02),
                        Gender= (Gender)1
                    },
                new CustomUser
                    {
                        Email= "ebostick2f@wisc.edu",
                        FName= "Estel",
                        LName= "Bostick",
                        Street= "Welch",
                        HouseNumber= 38,
                        ZipCode= null,
                        City= "Khān Neshīn",
                        BirthDate= new DateTime(2004,5,20),
                        Gender= (Gender)1
                    },
                new CustomUser
                    {
                        Email= "adavydkov2g@sun.com",
                        FName= "Aldus",
                        LName= "Davydkov",
                        Street= "Luster",
                        HouseNumber= 82913,
                        ZipCode= null,
                        City= "Hangou",
                        BirthDate= new DateTime(2004,5,24),
                        Gender= 0
                    },
                new CustomUser
                    {
                        Email= "ebolmann2h@ameblo.jp",
                        FName= "Edithe",
                        LName= "Bolmann",
                        Street= "6th",
                        HouseNumber= 876,
                        ZipCode= "612830",
                        City= "Rudnichnyy",
                        BirthDate= new DateTime(2004,8,27),
                        Gender= (Gender)1
                    },
                new CustomUser
                    {
                        Email= "uswann2i@weebly.com",
                        FName= "Ulrick",
                        LName= "Swann",
                        Street= "Kennedy",
                        HouseNumber= 52621,
                        ZipCode= "755 01",
                        City= "Vsetín",
                        BirthDate= new DateTime(2004,12,27),
                        Gender= 0
                    },
                new CustomUser
                    {
                        Email= "tminnette2j@dedecms.com",
                        FName= "Tamarra",
                        LName= "Minnette",
                        Street= "Gerald",
                        HouseNumber= 36,
                        ZipCode= "86390,000",
                        City= "Cambará",
                        BirthDate= new DateTime(2004,1,07),
                        Gender= (Gender)1
                    },
                new CustomUser
                    {
                        Email= "deldredge2k@woothemes.com",
                        FName= "Dennis",
                        LName= "Eldredge",
                        Street= "Mesta",
                        HouseNumber= 5613,
                        ZipCode= "79260,000",
                        City= "Bela Vista",
                        BirthDate= new DateTime(2004,8,20),
                        Gender= 0
                    },
                new CustomUser
                    {
                        Email= "glewis2l@hud.gov",
                        FName= "Guenna",
                        LName= "Lewis",
                        Street= "Linden",
                        HouseNumber= 9244,
                        ZipCode= "666021",
                        City= "Baklashi",
                        BirthDate= new DateTime(2004,1,25),
                        Gender= (Gender)1
                    },
                new CustomUser
                    {
                        Email= "rmaunton2m@1688.com",
                        FName= "Rem",
                        LName= "Maunton",
                        Street= "Loeprich",
                        HouseNumber= 55,
                        ZipCode= null,
                        City= "Wakaseko",
                        BirthDate= new DateTime(2004,4,07),
                        Gender= 0
                    },
                new CustomUser
                    {
                        Email= "atidbold2n@wisc.edu",
                        FName= "Abie",
                        LName= "Tidbold",
                        Street= "Bay",
                        HouseNumber= 915,
                        ZipCode= "35164 CEDEX",
                        City= "Montfort,sur,Meu",
                        BirthDate= new DateTime(2004,6,25),
                        Gender= 0
                    },
                new CustomUser
                    {
                        Email= "kbowcher2o@jigsy.com",
                        FName= "Kinny",
                        LName= "Bowcher",
                        Street= "Ludington",
                        HouseNumber= 6358,
                        ZipCode= "4785,035",
                        City= "Outeirô",
                        BirthDate= new DateTime(2004,7,28),
                        Gender= 0
                    },
                new CustomUser
                    {
                        Email= "dfort2p@nationalgeographic.com",
                        FName= "Devlen",
                        LName= "Fort",
                        Street= "Jenifer",
                        HouseNumber= 157,
                        ZipCode= null,
                        City= "Malo",
                        BirthDate= new DateTime(2004,6,12),
                        Gender= 0
                    },
                new CustomUser
                    {
                        Email= "wlafferty2q@thetimes.co.uk",
                        FName= "Wit",
                        LName= "Lafferty",
                        Street= "Meadow Vale",
                        HouseNumber= 97834,
                        ZipCode= null,
                        City= "Kotabaru",
                        BirthDate= new DateTime(2004,1,22),
                        Gender= 0
                    },
                new CustomUser
                    {
                        Email= "hnecrews2r@soundcloud.com",
                        FName= "Hugo",
                        LName= "Necrews",
                        Street= "Lillian",
                        HouseNumber= 5,
                        ZipCode= "22179",
                        City= "Hamburg Bramfeld",
                        BirthDate= new DateTime(2004,5,06),
                        Gender= 0
                    }
            }

            string password = "Egakko_92";

            foreach (var cTeacher in customUserTeacher)
            {

                if (userManager.FindByEmailAsync(cTeacher.Email).Result != null)
                    continue;
                try
                {
                    cTeacher.UserName = cTeacher.Email;
                    IdentityResult result = await userManager.CreateAsync(cTeacher, password);
                    if (result.Succeeded)
                    {
                        IdentityRole role = await roleManager.FindByNameAsync("teacher");
                        userManager.AddToRoleAsync(cTeacher, role.Name).Wait();

                        var teacher = new Teacher(cTeacher.Id);
                        applicationDbContext.Teachers.Add(teacher);

                    }

                }
                catch (Exception)
                {

                    throw;
                }


            }

            foreach (var cStudent in customUserStudent)
            {
                if (userManager.FindByEmailAsync(cStudent.Email).Result != null)
                    continue;
                try
                {
                    cStudent.UserName = cStudent.Email;
                    IdentityResult result = await userManager.CreateAsync(cStudent, password);
                    if (result.Succeeded)
                    {
                        IdentityRole role = await roleManager.FindByNameAsync("student");
                        userManager.AddToRoleAsync(cStudent, role.Name).Wait();
                        var student = new Student(cStudent.Id, 0, 0);
                        applicationDbContext.Students.Add(student);
                    }

                }
                catch (Exception)
                {
                    throw;
                }

            }

            foreach (var defaultUser in defaultUsers)
            {
                if (userManager.FindByEmailAsync(defaultUser.Email).Result != null)
                    continue;
                try
                {
                    defaultUser.UserName = defaultUser.Email;
                    IdentityResult result = await userManager.CreateAsync(defaultUser, password);
                    if (result.Succeeded)
                    {
                        IdentityRole role = await roleManager.FindByNameAsync("default");
                        userManager.AddToRoleAsync(defaultUser, role.Name).Wait();
                        var student = new Student(defaultUser.Id, 0, 0);
                        applicationDbContext.Students.Add(student);
                    }

                }
                catch (Exception)
                {
                    throw;
                }

            }

            applicationDbContext.SaveChanges();


        }

        public static async Task CreateRoles(RoleManager<IdentityRole> roleManager, ApplicationDbContext context)
        {


            IdentityResult result;

            bool rolecheck = await roleManager.RoleExistsAsync("defaultUser");
            if (!rolecheck)
                result = await roleManager.CreateAsync(new IdentityRole("defaultUser"));

            rolecheck = await roleManager.RoleExistsAsync("admin");
            if (!rolecheck)
                result = await roleManager.CreateAsync(new IdentityRole("admin"));

            rolecheck = await roleManager.RoleExistsAsync("teacher");
            if (!rolecheck)
                result = await roleManager.CreateAsync(new IdentityRole("teacher"));


            rolecheck = await roleManager.RoleExistsAsync("student");
            if (!rolecheck)
                result = await roleManager.CreateAsync(new IdentityRole("student"));



            context.SaveChanges();
        }
    }
}
