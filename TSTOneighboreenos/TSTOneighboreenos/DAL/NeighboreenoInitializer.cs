using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TSTOneighboreenos.Models;


namespace TSTOneighboreenos.DAL
{
    public class NeighboreenoInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<NeighboreenoContext>
    {
        protected override void Seed(NeighboreenoContext context)
        {
            var players = new List<Player>
            {
                new Player{TSTOhandle="jtsmith",Lv=21,NameFirst="John",NameLast="Smith",MidInit='T',Email="jtsmith@test.com",SFpath="~/Content/Images/springfields/tsto_homeScreen-tmb.png",Active=true,AddMe=true},
                new Player{TSTOhandle="BillyBoy428",Lv=30,NameFirst="Bill",NameLast="Johnson",MidInit='M',Email="BillyBoy428@test.com",SFpath="~/Content/Images/springfields/tsto_homeScreen-tmb.png",Active=true,AddMe=true},
                new Player{TSTOhandle="LisaIsGr8",Lv=09,NameFirst="Lisa",NameLast="Kinderson",MidInit='A',Email="LisaIsGr8@test.com",SFpath="~/Content/Images/springfields/tsto_homeScreen-tmb.png",Active=true,AddMe=true},
                new Player{TSTOhandle="fhonda",Lv=42,NameFirst="Frank",NameLast="Honda",MidInit='N',Email="fhonda@test.com",SFpath="~/Content/Images/springfields/tsto_homeScreen-tmb.png",Active=true,AddMe=true},
                new Player{TSTOhandle="NatShell",Lv=48,NameFirst="Natalie",NameLast="Shelly",MidInit='B',Email="NatShell@test.com",SFpath="~/Content/Images/springfields/tsto_homeScreen-tmb.png",Active=true,AddMe=true}
            };

            players.ForEach(p => context.Players.Add(p));
            context.SaveChanges();

            var neighbors = new List<Neighbor>
            {
                new Neighbor{TSTOhandle="BillyBoy428",Lv=30,SFpath="~/Content/Images/springfields/tsto_homeScreen-tmb.png",Active=true},
                new Neighbor{TSTOhandle="LisaIsGr8",Lv=09,SFpath="~/Content/Images/springfields/tsto_homeScreen-tmb.png",Active=true},
                new Neighbor{TSTOhandle="jtsmith",Lv=21,SFpath="~/Content/Images/springfields/tsto_homeScreen-tmb.png",Active=true},
                new Neighbor{TSTOhandle="fhonda",Lv=42,SFpath="~/Content/Images/springfields/tsto_homeScreen-tmb.png",Active=true},
                new Neighbor{TSTOhandle="NatShell",Lv=48,SFpath="~/Content/Images/springfields/tsto_homeScreen-tmb.png",Active=true},

            };

            neighbors.ForEach(n => context.Neighbors.Add(n));
            context.SaveChanges();

            var galleries = new List<Gallery>
            {
                new Gallery{ImgPath="~/Content/Images/gallery/abandoned/thumb/AbandonedSF_dylanchallen-tmb.png",Title="",Desc="",Abandon=true},
                new Gallery{ImgPath="~/Content/Images/gallery/abandoned/thumb/AbandonedSF_EVILNOCTURNE-tmb.png",Title="",Desc="",Abandon=true},
                new Gallery{ImgPath="~/Content/Images/gallery/abandoned/thumb/AbandonedSF_hulkavitch-tmb.png",Title="",Desc="",Abandon=true},
                new Gallery{ImgPath="~/Content/Images/gallery/abandoned/thumb/AbandonedSF_MinedTiger7-tmb.png",Title="",Desc="",Abandon=true},
                new Gallery{ImgPath="~/Content/Images/gallery/abandoned/thumb/AbandonedSF_dylanchallen-tmb.png",Title="",Desc="",Abandon=true},
                new Gallery{ImgPath="~/Content/Images/gallery/coolshots/thumb/CoolShots_EVILNOCTURNE-Aztec01-tmb.png",Title="",Desc="",Cool=true},
                new Gallery{ImgPath="~/Content/Images/gallery/coolshots/thumb/CoolShots_EVILNOCTURNE-Aztec02-tmb.png",Title="",Desc="",Cool=true},
                new Gallery{ImgPath="~/Content/Images/gallery/coolshots/thumb/CoolShots_EVILNOCTURNE-CletusFarm-tmb.png",Title="",Desc="",Cool=true},
                new Gallery{ImgPath="~/Content/Images/gallery/coolshots/thumb/CoolShots_MinedTiger7-lemonTree-tmb.png",Title="",Desc="",Cool=true},
                new Gallery{ImgPath="~/Content/Images/gallery/coolshots/thumb/CoolShots_wutpain-driveIn01-tmb.png",Title="",Desc="",Cool=true},
                new Gallery{ImgPath="~/Content/Images/gallery/coolshots/thumb/CoolShots_wutpain-drivein02-tmb.png",Title="",Desc="",Cool=true},
                new Gallery{ImgPath="~/Content/Images/gallery/coolshots/thumb/CoolShots_EVILNOCTURNE-Aztec01-tmb.png",Title="",Desc="",Cool=true}
            };

            galleries.ForEach(g => context.Galleries.Add(g));
            context.SaveChanges();
        }

        
            
    }
}