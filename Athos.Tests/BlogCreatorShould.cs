using NUnit.Framework;
using System;

namespace Athos.Tests
{
    [TestFixture]
    public class BlogCreatorShould
    {
        [Test]
        public void CreateNewEmptyBlogPost_GivenATitle_WithDateAdded()
        {
            var testBlogUser = new TestBlogUser();

            testBlogUser.WhenICreateNewBlogPostWithTitle("Its a title");

            testBlogUser.AndWriteSomeContent("here is some content");

            var blogPost = testBlogUser.WhenIRetrieveTheBlogPostByTitle("Its a title");

            Assert.AreEqual("here is some content", blogPost.Content);
        }
    }

    internal class TestBlogUser
    {
        public TestBlogUser()
        {
        }

        internal void AndWriteSomeContent(string v)
        {
            throw new NotImplementedException();
        }

        internal void WhenICreateNewBlogPostWithTitle(string v)
        {
            throw new NotImplementedException();
        }

        internal BlogPost WhenIRetrieveTheBlogPostByTitle(string v)
        {
            throw new NotImplementedException();
        }
    }
}
