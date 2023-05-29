using Assignment;

namespace AssignmentTest
{
    [TestClass]
    public class AssignmentTests
    {
        [TestMethod]
        public void OpenLockedTest()
        {
            // Chest starts in the locked state
            TreasureChest chest = new TreasureChest(TreasureChest.State.Locked);

            // Try to open the chest
            chest.Open();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Locked);

            // Unlock the chest
            chest.Unlock();
            chest.Open();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Open);

            // Close the chest
            chest.Close();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Closed);

            // Lock the chest
            chest.Lock();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Locked);
        }

        [TestMethod]
        public void OpenClosedTest()
        {
            // Create a new chest that is in the closed state
            TreasureChest chest = new TreasureChest(TreasureChest.State.Closed);

            // Unlock the chest
            chest.Unlock();
            chest.Open();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Open);

            // Close the chest
            chest.Close();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Closed);

            // Lock the chest
            chest.Lock();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Locked);
        }

        [TestMethod]
        public void OpenOpenTest()
        {
            // Create a new chest that is in the open state
            TreasureChest chest = new TreasureChest(TreasureChest.State.Open);

            // Close the chest
            chest.Close();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Closed);

            // Lock the chest
            chest.Lock();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Locked);

            // Unlock the chest
            chest.Unlock();
            chest.Open();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Open);
        }
    }
}
