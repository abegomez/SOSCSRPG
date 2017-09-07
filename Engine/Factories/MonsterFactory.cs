using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    public static class MonsterFactory
    {
        public static Monster GetMonster(int monsterID)
        {
            switch(monsterID)
            {
                case 1:
                    Monster snake =
                        new Monster("Snake", "Snake.png", 4, 4, 1, 2, 5, 1);
                    AddLootItem(snake, 9001, 25);
                    AddLootItem(snake, 9002, 75);
                    //AddLootItem(snake, 1002, 10);
                    return snake;

                case 2:
                    Monster rat =
                        new Monster("Rat", "Rat.png", 5, 5, 1, 2, 5, 1);
                    AddLootItem(rat, 9003, 25);
                    AddLootItem(rat, 9004, 75);
                    //AddLootItem(rat, 1002, 10);
                    return rat;

                case 3:
                    Monster giantSpider =
                        new Monster("Giant Spider", "GiantSpider.png", 10, 10, 1, 4, 10, 3);
                    AddLootItem(giantSpider, 9005, 25);
                    AddLootItem(giantSpider, 9006, 75);
                    //AddLootItem(giantSpider, 1002, 10);
                    return giantSpider;

                default:
                    throw new ArgumentException(string.Format("MonsterType '{0}' does not exist", monsterID));
            }
        }

        private static void AddLootItem(Monster monster, int itemID, int percentage)
        {
            Console.WriteLine("this item added: " + itemID);
            if (RandomNumberGenerator.NumberBetween(1, 100) <= percentage)
            {
                monster.Inventory.Add(new ItemQuantity(itemID, 1));
                
            }
        }
    }
}
