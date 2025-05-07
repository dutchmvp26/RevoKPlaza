let currentIndex = 0;

function showMod(index) {
    const mods = document.querySelectorAll('.featured-mod');
    console.log("Showing mod index:", index);
    mods.forEach((mod, i) => {
        mod.style.display = i === index ? 'block' : 'none';
        if (i === index) {
            console.log("Background image:", mod.style.backgroundImage);
        }
    });
}

function nextMod() {
    const mods = document.querySelectorAll('.featured-mod');
    currentIndex = (currentIndex + 1) % mods.length;
    showMod(currentIndex);
}

function prevMod() {
    const mods = document.querySelectorAll('.featured-mod');
    currentIndex = (currentIndex - 1 + mods.length) % mods.length;
    showMod(currentIndex);
}

document.addEventListener("DOMContentLoaded", () => showMod(currentIndex));
