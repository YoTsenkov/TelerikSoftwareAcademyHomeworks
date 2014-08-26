(function () {
    $('#reg-btn').on('click', function () {
        $.get('Views/register-view.html', function (data) {
            $('#wrapper').html(data);
            $('#register-button').on('click', function () {
                if ($('#username-reg').val().length < 6 || $('#username-reg').val() > 40) {
                    throw new RangeError('Invalid username. Should be between 6-40');
                }
                var username = $('#username-reg').val(),
                    password = $('#password-reg').val();

                User.register(username, password).
                    then(function () {
                        alert('Registration successful')
                    });
            });
        })
    });

    $('#login-btn').on('click', function () {
        $.get('Views/login-view.html', function (data) {
            $('#wrapper').html(data);
            $('#login-button').on('click', function () {
                var username = $('#username-login').val(),
                    password = $('#password-login').val();

                User.login(username, password).
                    then(function () {
                        alert('Hello ' + username)
                    });
            })
        })
    });

    $('#logout-btn').on('click', function () {
        User.logout();
        alert('You have logged out');
    });

    $('#post-crt').on('click', function () {
        if(localStorage['sessionKey']){
        $.get('Views/post-create-view.html', function (data) {
            $('#wrapper').html(data);

            $('#create-post').on('click', function () {
                var title = $('#post-title').val(),
                    body = $('#post-body').val();

                Post.create(title, body).
                    then(function () {
                        alert('Post created successfully')
                    });
            })
        })}else {
            $('#login-btn').trigger('click');
            alert('You are not logged in. Log in first.')

        }
    });

    $('#show-all-posts').on('click', function () {
        $.get('Views/all-posts-view.html', function (data) {
            $('#wrapper').html(data);

            Post.getAll().then(function (posts) {
                var li = $('<li>'),
                    h1 = $('<h3>'),
                    p = $('<p>'),
                    len = posts.length,
                    i;

                for (i = 0; i < len; i += 1) {
                    $('#post-list').append(
                        li.clone()
                            .append(p.clone().text('Post by ' + posts[i].user.username))
                            .append(h1.clone().text('Title: ' + posts[i].title))
                            .append(p.clone().text(posts[i].body)));
                }
            });
        })
    });
}());
