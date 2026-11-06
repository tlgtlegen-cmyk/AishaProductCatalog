(() => {
    const form = document.querySelector(".catalog-filters");
    const search = document.getElementById("catalogSearch");
    const category = document.getElementById("categoryFilter");

    if (!form) {
        return;
    }

    category?.addEventListener("change", () => form.requestSubmit());

    let searchTimeout;
    search?.addEventListener("input", () => {
        window.clearTimeout(searchTimeout);
        searchTimeout = window.setTimeout(() => form.requestSubmit(), 400);
    });
})();
