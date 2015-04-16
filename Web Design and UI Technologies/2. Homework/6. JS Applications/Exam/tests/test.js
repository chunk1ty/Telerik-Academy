define(['posts-controller'], function (PostsController) {
    describe('Posts controller', function () {
        var postsController = new PostsController();
        describe('Sorted posts', function () {
            it('Sorted by date without data test', function () {
                expect(postsController.getPostsSortedByDate([]).length).to.equal(0);
            });

            it('Sorted by title without data test', function () {
                expect(postsController.getPostsSortedByTitle([]).length).to.equal(0);
            });

            it('Sorted by date one post test', function () {
                var post = {title: 'test', body: 'test'},
                    sortedPosts = postsController.getPostsSortedByDate([
                        post
                    ]);

                expect(sortedPosts[0]).to.equal(post);
            });

            it('Sorted by title one post test', function () {
                var post = {title: 'test', body: 'test'},
                    sortedPosts = postsController.getPostsSortedByTitle([
                        post
                    ]);

                expect(sortedPosts[0]).to.equal(post);
            });

            it('Sorted by date more posts text', function () {
                var posts = [
                    {title: 'test', body: 'test', postDate: '2014/04/04'},
                    {title: 'and test', body: 'and test', postDate: '2010/03/03'}
                    ],
                    sortedPosts = postsController.getPostsSortedByDate(posts);

                expect(sortedPosts[0]).to.equal(posts[1]);
                expect(sortedPosts[1]).to.equal(posts[0]);
            });

            it('Sorted by title more posts text', function () {
                var posts = [
                        {title: 'test', body: 'test'},
                        {title: 'and test', body: 'and test'}
                    ],
                    sortedPosts = postsController.getPostsSortedByTitle(posts);

                expect(sortedPosts[0]).to.equal(posts[1]);
                expect(sortedPosts[1]).to.equal(posts[0]);
            })
        });
    });
});