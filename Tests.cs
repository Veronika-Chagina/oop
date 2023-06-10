using System;
using System.Collections.Generic;
using Xunit;

namespace OOP_ICT.Tests
{
    public class CardTests
    {
        [Fact]
        public void ToString_ReturnsCorrectString()
        {
            var card = new Card("J", "hearts");
            var result = card.ToString();

            Assert.Equal("J hearts", result);
        }
    }

    public class DealerTests
    {
        [Fact]
        public void GetInstance_ReturnsSameInstance()
        {
            var dealer1 = Dealer.GetInstance();
            var dealer2 = Dealer.GetInstance();

            Assert.Equal(dealer1, dealer2);
        }

        [Fact]
        public void Deal_ReturnsCards()
        {
            var dealer = Dealer.GetInstance();
            var cards = dealer.Deal();

            Assert.IsType<List<Card>>(cards);
            Assert.NotEmpty(cards);
        }
    }
}