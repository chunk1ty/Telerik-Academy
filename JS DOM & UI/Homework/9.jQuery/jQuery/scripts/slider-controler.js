function nextSlide() {
    currentSlideIndex++;

    if (currentSlideIndex >= slides.length) {
        currentSlideIndex = 0;
    }

    clearInterval(auto);
    clearTimeout(timeout);
    auto = setInterval(nextSlide, INTERVAL_TIME);
    render(currentSlideIndex);
}

function previousSlide() {
    currentSlideIndex--;

    if (currentSlideIndex < 0) {
        currentSlideIndex = slides.length - 1;
    }

    clearInterval(auto);
    clearTimeout(timeout);
    auto = setInterval(nextSlide, INTERVAL_TIME);
    render(currentSlideIndex);
}

function render() {
    slider.fadeOut(500);

    timeout = setTimeout(function () {
        slider.html(slides[currentSlideIndex]);
        slider.fadeIn(700)
    }, 500);
}
 
var slideOne = '<h3>slide 1</h3>\
    <div class="slideContent"> Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel\
Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante. </div>';

var slideTwo = '<h3>sldie 2</h3><div class="slideContent">Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.\
Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.\
Fusce non varius purus aenean nec magna felis fusce vestibulum velit mollis odio sollicitudin lacinia aliquam posuere, sapien elementum lobortis tincidunt, turpis dui ornare nisl, sollicitudin interdum turpis nunc eget.\
Sem nulla eu ultricies orci praesent id augue nec lorem pretium congue sit amet ac nunc fusce iaculis lorem eu diam hendrerit at mattis purus dignissim vivamus mauris tellus, fringilla.\
Vel dapibus a, blandit quis erat vivamus elementum aliquam luctus etiam fringilla pretium sem vitae sodales mauris id nulla est praesent laoreet, metus vel auctor aliquam, eros purus vulputate leo.</div>';

var sldieThree = '<h1>slide 3</h2>\
<div class="slideContent">\
Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.\
Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.\
</div>';

var slideFour = '<h1>slide 4</h1>\
<div class="slideContent">\
Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.\
Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.\
Fusce non varius purus aenean nec magna felis fusce vestibulum velit mollis odio sollicitudin lacinia aliquam posuere, sapien elementum lobortis tincidunt, turpis dui ornare nisl, sollicitudin interdum turpis nunc eget.\
Sem nulla eu ultricies orci praesent id augue nec lorem pretium congue sit amet ac nunc fusce iaculis lorem eu diam hendrerit at mattis purus dignissim vivamus mauris tellus, fringilla.\
</div>';

var slides = [slideOne, slideTwo, sldieThree, slideFour];
var INTERVAL_TIME = 5000;

$('#previous').on('click', previousSlide);
$('#next').on('click', nextSlide);

var slider = $('#slider');
//slider.css('margin-left', $(window).width() / 2 - 100);

var currentSlideIndex = 0;
var auto = setInterval(nextSlide, INTERVAL_TIME);
var timeout = 0;

render();