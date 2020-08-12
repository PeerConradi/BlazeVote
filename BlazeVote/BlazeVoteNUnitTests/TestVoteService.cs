using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using BlazeVote;

namespace BlazeVoteNUnitTests
{
    public class TestVoteService
    {
        private static BlazeVote.Data.VoteGroup _group = null;
        private static BlazeVote.Data.PublicKey _publicKey = null;

        /// <summary>
        /// This test should create a vote group that can be used in later tests
        /// </summary>
        [Test]
        [Order(1)]
        public void TestCreateVoteGroup()
        {
            var service = new BlazeVote.Services.VoteService();
            _group = service.GenerateNewVoteGroup();
            Assert.NotNull(_group);
            Assert.NotNull(_group.HiddenKeys);
            Assert.NotNull(_group.PublicKeys);
        }

        [Test]
        [Order(2)]
        public void TestGenerateAPublicKey()
        {
            var service = new BlazeVote.Services.VoteService();
            _publicKey = service.GeneratePublicKey(_group);
            Assert.NotNull(_publicKey);
            Assert.IsFalse(string.IsNullOrEmpty(_publicKey.PublicKeyId));
            Assert.IsFalse(_publicKey.IsRegistered);
            Assert.Contains(_publicKey, _group.PublicKeys);
        }

        [Test]
        [Order(3)]
        public void TestConvertToHiddenKey()
        {
            var service = new BlazeVote.Services.VoteService();
            var hiddenKey = service.GenerateHiddenKey(_group, _publicKey.PublicKeyId);
            Assert.NotNull(hiddenKey);
        }
    }
}
