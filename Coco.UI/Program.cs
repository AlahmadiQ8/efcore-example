using System;
using System.Collections.Generic;
using System.Linq;
using Coco.Data;
using Coco.Domain;

namespace Coco.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //InsertSamurai();
            //InsertMultipleSamurais();
            //SimpleSamuraiQuery();
            MoreQueries();
        }

        private static void MoreQueries()
        {
            using (var context = new SamuraiContext())
            {
                var samurais = context.Samurais.Where(s => s.Name == "Sammy").ToList();
            }
        }

        private static void SimpleSamuraiQuery()
        {
            using (var context = new SamuraiContext())
            {
                var samurais = context.Samurais.ToList();
            }
        }

        private static void InsertSamurai()
        {
            var samurai = new Samurai { Name = "Julie" };
            using (var context = new SamuraiContext())
            {
                context.Samurais.Add((samurai));
                context.SaveChanges();
            }
        }

        private static void InsertMultipleSamurais()
        {
            var samurai = new Samurai { Name = "Julie" };
            var samuraiSammy = new Samurai { Name = "Sammy" };
            using (var context = new SamuraiContext())
            {
                context.AddRange(samurai, samuraiSammy);
                context.SaveChanges();
            }
        }
    }
}
