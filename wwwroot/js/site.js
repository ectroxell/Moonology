function handleTableRowClick(rowId) {
    document.location = `/Journal/Details/${rowId}`;
}
function updateUI() {

    if (localStorage.currentTheme == null) {
        localStorage.currentTheme = 'bg-pink-clouds';
    }

    document.documentElement.style.setProperty('--background-image', `url(../imgs/${localStorage.currentTheme}.jpg)`);
}
function changeBackground(newBackground) {
  

    selectedTheme = newBackground === 'blue' ? 'bg-blue-nebula' : 'bg-pink-clouds';

    localStorage.currentTheme = selectedTheme;
    
    updateUI();
}


updateUI();