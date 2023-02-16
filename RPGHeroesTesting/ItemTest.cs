using RPG_Heroes.Heroes.HeroClasses;
using RPG_Heroes.Heroes;
using RPG_Heroes.Items;
using RPG_Heroes.Heroes.Exceptions;

namespace RPGHeroesTesting
{
    public class ItemTest
    {
        [Fact]
        public void EquipArmor_CreateAndEquipValidArmor_ShouldIncludeCorrectInfo()
        {
            //Arrange
            Mage testHero = new Mage("Test");
            Armor testArmor = new Armor("Clingy Cloth", 1, Slot.Body, ArmorType.cloth, new HeroAttribute(1, 2, 1));
            testHero.EquipArmor(testArmor);
            string expectedName = "Clingy Cloth";
            int expectedLevel = 1;
            ArmorType expectedArmorType = ArmorType.cloth;

            //Act

            string? actualName = testHero.equipment[Slot.Body].Name;
            int actualLevel = testHero.equipment[Slot.Body].RqLevel;
            Armor userArmor = (Armor)testHero.equipment[Slot.Body];
            ArmorType actualType = userArmor.Type;

            //Assert
            Assert.Equal(expectedName, actualName);
            Assert.Equal(expectedLevel, actualLevel);
            Assert.Equal(expectedArmorType, actualType);

        }

        [Fact]
        public void EquipWeapon_CreateAndEquipValidWeapon_ShouldIncludeCorrectInfo()
        {
            //Arrange
            Mage testHero = new Mage("Test");
            Weapon testWeapon = new Weapon("Tippy Staff", 2, Slot.Weapon, WeaponType.staff, 11);
            testHero.LevelUp();
            testHero.EquipWeapon(testWeapon);
            string expectedName = "Tippy Staff";
            int expectedLevel = 2;
            WeaponType expectedWeaponType = WeaponType.staff;

            //Act

            string? actualName = testHero.equipment[Slot.Weapon].Name;
            int actualLevel = testHero.equipment[Slot.Weapon].RqLevel;
            Weapon userWeapon = (Weapon)testHero.equipment[Slot.Weapon];
            WeaponType actualType = userWeapon.Type;

            //Assert
            Assert.Equal(expectedName, actualName);
            Assert.Equal(expectedLevel, actualLevel);
            Assert.Equal(expectedWeaponType, actualType);

        }

        [Fact]
        public void EquipWeapon_LeveLRequirementNotMet_ShouldThrowInvalidWeaponException()
        {
            //Arrange
            Warrior testHero = new Warrior("Test");
            Weapon testWeapon = new Weapon("Hard Hammer", 5, Slot.Weapon, WeaponType.hammer, 9);

            //Act and Assert
            Assert.Throws<InvalidWeaponException>(() => testHero.EquipWeapon(testWeapon));
        }

        [Fact]
        public void EquipArmor_LeveLRequirementNotMet_ShouldThrowInvalidArmorException()
        {
            //Arrange
            Warrior testHero = new Warrior("Test");
            Armor testWeapon = new Armor("Pretty Plate", 4, Slot.Body, ArmorType.plate, new HeroAttribute(1, 2, 1));

            //Act and Assert
            Assert.Throws<InvalidArmorException>(() => testHero.EquipArmor(testWeapon));
        }

        [Fact]
        public void EquipArmor_InvalidArmorTypeForHero_ShouldThrowInvalidArmorException()
        {
            //Arrange
            Warrior testHero = new Warrior("Test");
            Armor testWeapon = new Armor("Clingy Cloth", 1, Slot.Body, ArmorType.cloth, new HeroAttribute(1, 2, 1));

            //Act and Assert
            Assert.Throws<InvalidArmorException>(() => testHero.EquipArmor(testWeapon));
        }


        [Fact]
        public void EquipWeapon_InvalidArmortypeForHero_ShouldThrowInvalidWeaponException()
        {
            //Arrange
            Mage testHero = new Mage("Test");
            Weapon testWeapon = new Weapon("Aggressive Axe", 1, Slot.Weapon, WeaponType.axe, 2);

            //Act and Assert
            Assert.Throws<InvalidWeaponException>(() => testHero.EquipWeapon(testWeapon));
        }

        [Fact]
        public void CalculateDamage_WithoutWeapon_ShouldReturnCorrectDamage()
        {
            //Arrange
            Mage testHero = new Mage("Test");
            decimal charDam = testHero.LevelAttributes.Intelligence;
            decimal expectedDamage = 1 * (1 + charDam / 100);

            //Act
            decimal actualDamage = testHero.CalculateDamage();

            //Assert
            Assert.Equal(expectedDamage,actualDamage);
        }

        [Fact]
        public void CalculateDamage_WithWeapon_ShouldReturnCorrectDamage()
        {
            //Arrange
            Mage testHero = new Mage("Test");
            Weapon testWeapon = new Weapon("Tippy Staff", 2, Slot.Weapon, WeaponType.staff, 11);
            testHero.LevelUp();
            testHero.EquipWeapon(testWeapon);
            decimal charDam = testHero.LevelAttributes.Intelligence;
            decimal expectedDamage = testWeapon.WeaponDamage * (1 + charDam / 100);

            //Act
            decimal actualDamage = testHero.CalculateDamage();

            //Assert
            Assert.Equal(expectedDamage, actualDamage);
        }


        [Fact]
        public void CalculateDamage_ChangeWeapon_ShouldReturnCorrectDamage()
        {
            //Arrange
            Mage testHero = new Mage("Test");
            Weapon testWeapon1 = new Weapon("Tippy Staff", 2, Slot.Weapon, WeaponType.staff, 11);
            Weapon testWeapon2 = new Weapon("Windy Wand", 2, Slot.Weapon, WeaponType.wand, 17);
            testHero.LevelUp();
            testHero.EquipWeapon(testWeapon1);
            testHero.EquipWeapon(testWeapon2);
            decimal charDam = testHero.LevelAttributes.Intelligence;
            decimal expectedDamage = testWeapon2.WeaponDamage * (1 + charDam / 100);

            //Act
            decimal actualDamage = testHero.CalculateDamage();

            //Assert
            Assert.Equal(expectedDamage, actualDamage);
        }

    }
}