namespace LeetCode.Tests;

public class AddTwoNumbersTests
{
    private readonly AddTwoNumbers addTwoNumbers;

    public AddTwoNumbersTests()
    {
        addTwoNumbers = new AddTwoNumbers();
    }

    [Fact]
    public void GivenThreeDidgets()
    {
        var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
        var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));

        var result = addTwoNumbers.Add(l1, l2);

        var expected = new ListNode(7, new ListNode(0, new ListNode(8)));
        result.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void GivenDifferentSizes()
    {
        var l1 = new ListNode(2, new ListNode(4, new ListNode(9)));
        var l2 = new ListNode(5, new ListNode(6, new ListNode(4, new ListNode(9))));

        var result = addTwoNumbers.Add(l1, l2);

        var expected = new ListNode(7, new ListNode(0, new ListNode(4, new ListNode(0, new ListNode(1)))));
        result.Should().BeEquivalentTo(expected);
    }
}