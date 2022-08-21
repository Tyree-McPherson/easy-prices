document.addEventListener("DOMContentLoaded", () => {
    // TODO:
    // I might not need this event listener.
});

// Once going off the index page, make the necessary transition.
function LeaveIndex() {

    // Change the colour of the footer.
    document.getElementById("footer-paragraph").classList.remove("text-white");
    document.getElementById("footer-paragraph").classList.add("text-black");

    // Get rid of the background image.
    document.getElementById("layout-container").classList.remove("landing-page-background-image");

    // Change the image (or colour) of the website logo.
    document.getElementById("website-logo").setAttribute("src", "/images/easy-prices-logo-inverted.png");

    // Add a background colour to the header.
    document.getElementsByTagName("header")[0].style.backgroundColor = "var(--colour-header)";

    // Change the colour of the "Home" link.
    document.getElementById("header-link-home").style.color = "var(--colour-white)";
}

function JoinIndex() {

    document.getElementById("footer-paragraph").classList.remove("text-black");
    document.getElementById("footer-paragraph").classList.add("text-white");

    document.getElementById("layout-container").classList.add("landing-page-background-image");

    document.getElementById("website-logo").setAttribute("src", "/images/easy-prices-logo-black.png");

    document.getElementsByTagName("header")[0].style.backgroundColor = "transparent";

    document.getElementById("header-link-home").style.color = "var(--colour-black)";
}