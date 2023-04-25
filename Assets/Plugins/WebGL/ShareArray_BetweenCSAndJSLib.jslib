mergeInto(LibraryManager.library, {
    setupShareArray: function (ptrArray, len) {
        debugger;
        window.shareArray = new Int32Array(buffer, ptrArray, len);
        const incrementButton = document.createElement('button');
        incrementButton.textContent = 'Increment array elements';
        incrementButton.onclick = function(evt) {
            for(let i = 0;i < window.shareArray.length; i++){
                window.shareArray[i]++;
            }
        };
        incrementButton.style.position = 'absolute';
        incrementButton.style.left = incrementButton.style.top = 0;
        incrementButton.style.zIndex = 10000;
        document.body.appendChild(incrementButton);
    }
});