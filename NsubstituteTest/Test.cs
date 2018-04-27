using NSubstitute;
using NUnit.Framework;

namespace NsubstituteTest
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void CheckReceived()
        {
            //ARRANGE
            var action = Substitute.For<IAction>();
            var person = new Person(){Name = "Leendert"};

            //ACT
            action.Act(person);
            person.Name = "Dommicent";

            //ASSERT
            action.Received().Act(Arg.Is<Person>(p => p.Name.Equals("Leendert")));
        }
    }
}
