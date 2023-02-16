using System;
using Xunit;
using RPG_Heroes.Heroes.HeroClasses;
using RPG_Heroes.Heroes;
using RPG_Heroes.Items;

namespace RPGHeroesTesting
{
    public class HeroTests
    {
  
        [Fact]
        public void Constructor_CreateHero_LevelShouldBeOne()
        {
            //Arrange
            string expectedName = "Test";
            Mage testHero = new Mage(expectedName);
            int expectedLevel = 1;

            //Act

            string actualName = testHero.Name;
            int actualLevel = testHero.Level;

            //Assert
            Assert.Equal(expectedName, actualName);
            Assert.Equal(expectedLevel, actualLevel);
        
        }
     
        [Fact]
        public void LevelUp_CallMethod_LevelShouldBeTwo()
        {
            //Arrange
            Mage testHero = new Mage("Test");
            int expectedLevel = 2;

            //Act
            testHero.LevelUp();
            int actualLevel = testHero.Level;

            //Assert
            Assert.Equal(expectedLevel, actualLevel);

        }
     
        [Fact]
        public void Constructor_CreateHeroMage_ShouldHaveCorrectAttributes()
        {
            //Arrange
            Mage mage = new Mage("Test");
            int expectedStrength = 1;
            int expectedDexterity = 1;
            int expectedIntelligence = 8;


            //Act
            int actualStrength = mage.LevelAttributes.Strength;
            int actualDexterity = mage.LevelAttributes.Dexterity;
            int actualIntelligence = mage.LevelAttributes.Intelligence;


            //Assert
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
        }
       
        [Fact]
        public void Constructor_CreateHeroRanger_ShouldHaveCorrectAttributes()
        {
            //Arrange
            Ranger testHero = new Ranger("Test");
            int expectedStrength = 1;
            int expectedDexterity = 7;
            int expectedIntelligence = 1;


            //Act
            int actualStrength = testHero.LevelAttributes.Strength;
            int actualDexterity = testHero.LevelAttributes.Dexterity;
            int actualIntelligence = testHero.LevelAttributes.Intelligence;


            //Assert
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
        }
      
        [Fact]
        public void Constructor_CreateHeroRogue_ShouldHaveCorrectAttributes()
        {
            //Arrange
            Rogue testHero = new Rogue("Test");
            int expectedStrength = 2;
            int expectedDexterity = 6;
            int expectedIntelligence = 1;


            //Act
            int actualStrength = testHero.LevelAttributes.Strength;
            int actualDexterity = testHero.LevelAttributes.Dexterity;
            int actualIntelligence = testHero.LevelAttributes.Intelligence;


            //Assert
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
        }
      
        [Fact]
        public void Constructor_CreateHeroWarrior_ShouldHaveCorrectAttributes()
        {
            //Arrange
            Warrior testHero = new Warrior("Test");
            int expectedStrength = 5;
            int expectedDexterity = 2;
            int expectedIntelligence = 1;


            //Act
            int actualStrength = testHero.LevelAttributes.Strength;
            int actualDexterity = testHero.LevelAttributes.Dexterity;
            int actualIntelligence = testHero.LevelAttributes.Intelligence;


            //Assert
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
        }
     
        [Fact]
        public void LevelUp_CallMethodAsMage_ShouldHaveCorrectAttributes()
        {
            //Arrange
            Mage testHero = new Mage("Test");
            int expectedStrength = 2;
            int expectedDexterity = 2;
            int expectedIntelligence = 13;


            //Act
            testHero.LevelUp();
            int actualStrength = testHero.LevelAttributes.Strength;
            int actualDexterity = testHero.LevelAttributes.Dexterity;
            int actualIntelligence = testHero.LevelAttributes.Intelligence;


            //Assert
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
        }
        
        [Fact]
        public void LevelUp_CallMethodAsRanger_ShouldHaveCorrectAttributes()
        {
            //Arrange
            Ranger testHero = new Ranger("Test");
            int expectedStrength = 2;
            int expectedDexterity = 12;
            int expectedIntelligence = 2;


            //Act
            testHero.LevelUp();
            int actualStrength = testHero.LevelAttributes.Strength;
            int actualDexterity = testHero.LevelAttributes.Dexterity;
            int actualIntelligence = testHero.LevelAttributes.Intelligence;


            //Assert
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
        }
       
        [Fact]
        public void LevelUp_CallMethodAsRogue_ShouldHaveCorrectAttributes()
        {
            //Arrange
            Rogue testHero = new Rogue("Test");
            int expectedStrength = 3;
            int expectedDexterity = 10;
            int expectedIntelligence = 2;


            //Act
            testHero.LevelUp();
            int actualStrength = testHero.LevelAttributes.Strength;
            int actualDexterity = testHero.LevelAttributes.Dexterity;
            int actualIntelligence = testHero.LevelAttributes.Intelligence;


            //Assert
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
        }

        [Fact]
        public void LevelUp_CallMethodAsWarrior_ShouldHaveCorrectAttributes()
        {
            //Arrange
            Warrior testHero = new Warrior("Test");
            int expectedStrength = 8;
            int expectedDexterity = 4;
            int expectedIntelligence = 2;


            //Act
            testHero.LevelUp();
            int actualStrength = testHero.LevelAttributes.Strength;
            int actualDexterity = testHero.LevelAttributes.Dexterity;
            int actualIntelligence = testHero.LevelAttributes.Intelligence;


            //Assert
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
        }


        [Fact]
        public void TotalAttributes_WithArmor_ShouldHaveCorrectValues()
        {
            //Arrange
            Ranger testHero = new Ranger("Test");
            Armor armor = new Armor("Minumum Mail", 2, Slot.Body, ArmorType.mail, new HeroAttribute(1, 2, 1));
            testHero.LevelUp();
            testHero.EquipArmor(armor);

            int expectedStrength = 3;
            int expectedDexterity = 14;
            int expectedIntelligence = 3;


            //Act
            int actualStrength = testHero.LevelAttributes.Strength;
            int actualDexterity = testHero.LevelAttributes.Dexterity;
            int actualIntelligence = testHero.LevelAttributes.Intelligence;


            //Assert
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
        }


        [Fact]
        public void TotalAttributes_WithChangingArmor_ShouldHaveCorrectValues()
        {
            //Arrange
            Ranger testHero = new Ranger("Test");
            Armor armor1 = new Armor("Minumum Mail", 2, Slot.Body, ArmorType.mail, new HeroAttribute(1, 2, 1));
            Armor armor2 = new Armor("Lousy Leather", 3, Slot.Body, ArmorType.leather, new HeroAttribute(1, 2, 1));
            testHero.LevelUp();
            testHero.LevelUp();
            testHero.EquipArmor(armor1);
            testHero.EquipArmor(armor2);

            int expectedStrength = 4;
            int expectedDexterity = 19;
            int expectedIntelligence = 4;


            //Act
            int actualStrength = testHero.LevelAttributes.Strength;
            int actualDexterity = testHero.LevelAttributes.Dexterity;
            int actualIntelligence = testHero.LevelAttributes.Intelligence;


            //Assert
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
        }
    }
}