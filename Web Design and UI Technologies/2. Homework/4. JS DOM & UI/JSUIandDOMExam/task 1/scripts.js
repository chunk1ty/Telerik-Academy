function createImagesPreviewer(selector, items) {
    var container = document.querySelector(selector);
    var items = items;

    var leftTabContainer = document.createElement('div');
    leftTabContainer.style.width = '600px';
    leftTabContainer.style.height = '600px';
    leftTabContainer.style.textAlign = 'center';
    leftTabContainer.style.display = 'inline-block';
    leftTabContainer.style.verticalAlign = 'top';
    leftTabContainer.classList.add('left-tab');

    var leftImageHeader = document.createElement('h1');
    leftImageHeader.classList.add('left-header');

    var leftImage = document.createElement('img');
    leftImage.style.borderRadius = '15px';
    leftImage.style.width = '550px';
    leftImage.classList.add('left-image');

    var rightTabContainer = document.createElement('div');
    rightTabContainer.style.width = '230px';
    rightTabContainer.style.height = '600px';
    rightTabContainer.style.overflowY = 'scroll';
    rightTabContainer.style.display = 'inline-block';
    rightTabContainer.classList.add('right-tab');

    var filterContainer = document.createElement('div');
    filterContainer.style.textAlign = 'center';
    filterContainer.classList.add('filter-container');

    var filterHeader = document.createElement('p');
    filterHeader.style.fontSize = '18px';
    filterHeader.style.margin = '0';
    filterHeader.innerText = 'Filter';

    var filterInput = document.createElement('input');
    filterInput.style.width = '190px';
    filterInput.classList.add('filter-input');
    filterInput.setAttribute('type', 'text');

    var thumbnailContainer = document.createElement('div');
    thumbnailContainer.style.textAlign = 'center';
    thumbnailContainer.classList.add('thumbnail-container');

    var thumbnailDiv = document.createElement('div');
    thumbnailDiv.classList.add('thumbnail-box');

    var thumbnailImage = document.createElement('img');
    thumbnailImage.width = '200';
    thumbnailImage.style.borderRadius = '5px';
    thumbnailImage.classList.add('thumbnail-image');

    var thumbnailHeader = document.createElement('h2');
    thumbnailHeader.style.margin = '0';
    thumbnailHeader.classList.add('thumbnail-header');

    var currentLeftImageHeader = leftImageHeader.cloneNode(true);
    currentLeftImageHeader.innerText = items[0]['title'];

    var currentLeftImage = leftImage.cloneNode(true);
    currentLeftImage.setAttribute('src', items[0]['url']);

    leftTabContainer.appendChild(currentLeftImageHeader);
    leftTabContainer.appendChild(currentLeftImage);

    filterContainer.appendChild(filterHeader);
    filterContainer.appendChild(filterInput);

    for (var i = 0; i < items.length; i += 1) {
        var currentThumbnailDiv = thumbnailDiv.cloneNode(true);

        var currentThumbnailHeader = thumbnailHeader.cloneNode(true);
        currentThumbnailHeader.innerText = items[i]['title'];

        var currentThumbnailImage = thumbnailImage.cloneNode(true);
        currentThumbnailImage.setAttribute('src', items[i]['url']);

        currentThumbnailDiv.appendChild(currentThumbnailHeader);
        currentThumbnailDiv.appendChild(currentThumbnailImage);
        thumbnailContainer.appendChild(currentThumbnailDiv);
    }

    rightTabContainer.appendChild(filterContainer);
    rightTabContainer.appendChild(thumbnailContainer);
    container.appendChild(leftTabContainer);
    container.appendChild(rightTabContainer);

    var thumbnails = container.getElementsByClassName('thumbnail-container')[0];

    thumbnails.addEventListener('mouseover', function (ev) {
        if (ev.target.parentNode.classList.contains('thumbnail-box') && !ev.target.parentNode.classList.contains('selected')) {
            var target = ev.target.parentNode;
            target.style.backgroundColor = 'lightgrey';
        }
    });
    thumbnails.addEventListener('mouseout', function (ev) {
        if (ev.target.parentNode.classList.contains('thumbnail-box') && !ev.target.parentNode.classList.contains('selected')) {
            var target = ev.target.parentNode;
            target.style.backgroundColor = 'white';
        }
    });

    thumbnails.addEventListener('click', function (ev) {
        if (ev.target.parentNode.classList.contains('thumbnail-box')) {
            var target = ev.target.parentNode;

            var oldSelected = thumbnails.getElementsByClassName('selected');
            if (oldSelected.length) {
                oldSelected[0].style.backgroundColor = 'white';
                oldSelected[0].classList.remove('selected');
            }

            target.classList.add('selected');
            target.style.backgroundColor = 'darkgrey';

            var currentThumbnailHeader = target.getElementsByClassName('thumbnail-header')[0];
            var currentThumbnailImage = target.getElementsByClassName('thumbnail-image')[0];

            var leftContainer = container.getElementsByClassName('left-tab')[0];
            var leftHeader = leftContainer.getElementsByClassName('left-header')[0];
            var leftImage = leftContainer.getElementsByClassName('left-image')[0];
            leftHeader.innerText = currentThumbnailHeader.innerText;
            leftImage.setAttribute('src', currentThumbnailImage.getAttribute('src'));
        }
    });

    var filterContainer = container.getElementsByClassName('filter-container')[0];
    var filterInput = filterContainer.getElementsByClassName('filter-input')[0];

    filterInput.addEventListener('keyup', function (ev) {
        var target = this;
        var value = target.value.toLowerCase();
        var allThumbnails = container.getElementsByClassName('thumbnail-container')[0];
        for (var i = 0; i < allThumbnails.children.length; i += 1) {
            var innerThumbnailText = allThumbnails.children[i].innerText.toLowerCase();
            if (innerThumbnailText.indexOf(value) == -1) {
                allThumbnails.children[i].style.display = 'none';
            } else {
                allThumbnails.children[i].style.display = '';
            }
        }
    });
}