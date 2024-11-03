// localStorageHelper.js
window.checkOnlineStatus = function () {
    var status = navigator.onLine;
    console.log(status);
    return status;
};
window.localStorageHelper = {
    loadNotes: function () {
        const savedNotes = localStorage.getItem("notes");
        return savedNotes ? savedNotes : JSON.stringify([]);
    },
    saveNotes: function (notes) {
        localStorage.setItem("notes", notes);
    },
    onOnline: function (dotnetHelper) {
        window.addEventListener('online', () => {
            dotnetHelper.invokeMethodAsync('SyncNotes');
        });
    },
    onOffline: function () {
        window.addEventListener('offline', () => {
            console.log('You are offline. Notes will be saved locally.');
        });
    }
};
