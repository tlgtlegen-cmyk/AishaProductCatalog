(() => {
    const navigation = document.getElementById("mainNavigation");
    const toggle = document.querySelector(".nav-toggle");

    if (!navigation || !toggle) {
        return;
    }

    navigation.addEventListener("shown.bs.collapse", () => {
        toggle.setAttribute("aria-expanded", "true");
        toggle.setAttribute("aria-label", "Мәзірді жабу");
    });

    navigation.addEventListener("hidden.bs.collapse", () => {
        toggle.setAttribute("aria-expanded", "false");
        toggle.setAttribute("aria-label", "Мәзірді ашу");
    });

    navigation.querySelectorAll("a").forEach((link) => {
        link.addEventListener("click", () => {
            if (window.matchMedia("(max-width: 991.98px)").matches) {
                bootstrap.Collapse.getOrCreateInstance(navigation).hide();
            }
        });
    });
})();
