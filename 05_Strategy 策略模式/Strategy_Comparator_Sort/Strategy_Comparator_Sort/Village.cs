using System;
using System.Collections.Generic;

namespace Strategy_Comparator_Sort
{
    public class Village
    {
        public int id;
        public String name;
        public int population;
        public double area;

        public Village(int id, String name, int population, double area)
        {
            this.id = id;
            this.name = name;
            this.population = population;
            this.area = area;
        }

        public override string ToString()
        {
            return id + "." + name + "人口: " + population + "面積: " + area + ")";
        }
    }

    public class SortVillageById : Comparer<Village>
    {
        public override int Compare(Village o1, Village o2)
        {
            if (o1.id > o2.id)
                return 1;

            if (o2.id < o2.id)
                return -1;

            return 0;
        }
    }

    public class SortVillageByArea: Comparer<Village>
    {
        public override int Compare(Village o1, Village o2)
        {
            if (o1.area > o2.area)
                return 1;

            if (o2.area < o2.area)
                return -1;

            return 0;
        }
    }

    public class SortVillageByName : Comparer<Village>
    {
        public override int Compare(Village o1, Village o2)
        {
            if (o1.name[0] > o2.name[0])
                return 1;

            if (o2.name[0] < o2.name[0])
                return -1;

            return 0;
        }
    }

    public class SortVillageByPopulation : Comparer<Village>
    {
        public override int Compare(Village o1, Village o2)
        {
            if (o1.population > o2.population)
                return 1;

            if (o2.population < o2.population)
                return -1;

            return 0;
        }
    }
}
