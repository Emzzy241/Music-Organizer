using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrganizer.Models;
using System;
using System.Collections.Generic;

namespace MusicOrganizer
{
    [TestClass]
    public class ArtistTests : IDisposable
    {

        public void Dispose()
        {
            Artist.ClearAllArtists();
        }
        // Test 1. Test to Create Instance of Artist
        [TestMethod]
        public void ArtistConstructor_CreatesInstanceOfArtist_Artist()
        {
            // Arrange
            Artist newArtist1 = new Artist("Drake");

            // Assert
            Assert.AreEqual(typeof(Artist), newArtist1.GetType());
        }

        // Test 2. Test to Get Artist's name
        [TestMethod]
        public void GetArtistName_ReturnsNameOfArtist_String()
        {
            // Arrange
            Artist newArtist1 = new Artist("Chris Brown");
            string expectedArtistName = "Chris Brown";

            // Act
            string actualArtistName = newArtist1.ArtistName;

            // Assert
            Assert.AreEqual(expectedArtistName, actualArtistName);        
        }
            
        // Test 3. Test to set Aritist's name
        [TestMethod]
        public void SetArtistName_SetsArtistsName_Void()
        {
            // Arrange
            Artist newArtist1 = new Artist("BTS");
            string newArtist1Name = "Black Beetles";

            // Act
            newArtist1.ArtistName = newArtist1Name;

            // Assert
            Assert.AreEqual(newArtist1Name, newArtist1.ArtistName);
        }

        // Test 4. Test to get all artist's 
        [TestMethod]
        public void GetAllArtists_ReturnsAllArtist_List()
        {
            // Arrange
            Artist newArtist1 = new Artist("BTS");
            Artist newArtist2 = new Artist("Drake");
            Artist newArtist3 = new Artist("Serena");
            List<Artist> expectedListOfArtists = new List<Artist>(){newArtist1, newArtist2, newArtist3};

            // Act
            List<Artist> actualListOfArtists = Artist.GetAllArtists();

            // Assert
            CollectionAssert.AreEqual(expectedListOfArtists, actualListOfArtists);
        }

        // Test 5. Test to clear all artist's
        [TestMethod]
        public void ClearAllArtists_RemovesAllArtistFromList_Void()
        {
            // Arrange
            Artist newArtist1 = new Artist("BTS");
            Artist newArtist2 = new Artist("Drake");
            Artist newArtist3 = new Artist("Serena");
            List<Artist> expectedListOfArtists = new List<Artist>(){};

            // Act
            Artist.ClearAllArtists();
            List<Artist> actualListOfArtists = Artist.GetAllArtists();

            // Assert
            CollectionAssert.AreEqual(expectedListOfArtists, actualListOfArtists);
        }

        // Test 6. Test to Assign unique Id to each Artist instance
        [TestMethod]
        public void ArtistId_AssignIdtoArtistInstances_Int()
        {
            // Arrange
            Artist newArtist1 = new Artist("BTS");
            Artist newArtist2 = new Artist("Drake");
            Artist newArtist3 = new Artist("Serena");
            int expectedArtist1Id = 1;
            int expectedArtist2Id = 2;
            int expectedArtist3Id = 3;

            // Act
            int actualArtist1Id = newArtist1.ArtistId;
            int actualArtist2Id = newArtist2.ArtistId;
            int actualArtist3Id = newArtist3.ArtistId;

            // Assert
            Assert.AreEqual(expectedArtist1Id, actualArtist1Id);
            Assert.AreEqual(expectedArtist2Id, actualArtist2Id);
            Assert.AreEqual(expectedArtist3Id, actualArtist3Id);
        }

        // Test 7. Test to Find an Instance of Artist
        [TestMethod]
        public void FindInstance_ReturnsInstanceOfArtist_Object()
        {
            // Arrange
            Artist newArtist1 = new Artist("BTS");
            Artist newArtist2 = new Artist("Drake");
            Artist newArtist3 = new Artist("Serena");

            // Act
            Artist foundObject1 = Artist.FindArtist(newArtist1.ArtistId);
            Artist foundObject2 = Artist.FindArtist(newArtist2.ArtistId);
            Artist foundObject3 = Artist.FindArtist(newArtist3.ArtistId);

            // Assert
            Assert.AreEqual(newArtist1, foundObject1);
            Assert.AreEqual(newArtist2, foundObject2);
            Assert.AreEqual(newArtist3, foundObject3);
        }

        // Test 8. Test to delete a single Instance from list of artists
        [TestMethod]
        public void DeleteInstance_RemovesInstanceFromList_Void()
        {
            // Arrange
            Artist newArtist1 = new Artist("BTS");
            Artist newArtist2 = new Artist("Drake");
            Artist newArtist3 = new Artist("Serena");
            List<Artist> expectedListOfArtists = new List<Artist>(){newArtist2, newArtist3};

            // Act
            Artist.RemoveArtist(newArtist1.ArtistId);
            List<Artist> actualListOfArtists = Artist.GetAllArtists();

            // Assert
            CollectionAssert.AreEqual(expectedListOfArtists, actualListOfArtists);
        }


    }

        

}