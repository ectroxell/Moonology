function handleTableRowClick(rowId) {
    window.location = `/Journal/Details/${rowId}`;
}

function updateUI() {
    if (localStorage.currentTheme == null) {
        localStorage.currentTheme = 'bg-pink-clouds';
    }
    if (localStorage.textBgColor == null) {
        localStorage.textBgColor = 'rgb(185, 103, 190)'
    }

    document.documentElement.style.setProperty('--background-image', `url(../imgs/${localStorage.currentTheme}.jpg)`);
    document.documentElement.style.setProperty('--background-color', `${localStorage.textBgColor}`)
}

function changeBackground(newBackground) {
    let selectedTheme = newBackground === 'blue' ? 'bg-blue-nebula' : 'bg-pink-clouds';
    
    localStorage.textBgColor = newBackground === 'blue' ? 'rgb(14, 0, 50)' : 'rgb(185, 103, 190)';
    localStorage.currentTheme = selectedTheme;

    updateUI();
}

updateUI();