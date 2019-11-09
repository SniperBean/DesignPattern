using System;
namespace AbstractFactory
{
    /*
        裝備工廠介面(Factory) - 定義每一間工廠應該生產哪些東西
    */

    public interface EquipFactory
    {
        //製造武器
        Weapon produceWeapon();
        //製造衣服
        Clothes produceArmor();
    }

    public class WarriorEquipFactory : EquipFactory
    {
        public Weapon produceWeapon()
        {
            LongSword product = new LongSword();
            product.Atk = 10;
            product.Range = 1;
            return product;
        }

        public Clothes produceArmor()
        {
            Armor product = new Armor();
            product.Def = 10;
            return product;
        }
    }

    public class ArcherEquipFactory : EquipFactory
    {
        public Weapon produceWeapon()
        {
            Bow product = new Bow();
            product.Atk = 10;
            product.Range = 10;
            return product;
        }

        public Clothes produceArmor()
        {
            Leather product = new Leather();
            product.Def = 5;
            return product;
        }
    }

}
