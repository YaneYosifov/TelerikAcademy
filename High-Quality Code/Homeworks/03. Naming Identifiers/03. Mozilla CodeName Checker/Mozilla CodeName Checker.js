﻿function alertIfMozilla() {
    var currentWindow = window,
        browserName = currentWindow.navigator.appCodeName,
        isMozilla = (browserName === "Mozilla");
    if (isMozilla) {
        alert("Yes");
    } else {
        alert("No");
    }
}