// localStorageHelper.js
window.localStorageHelper = {
    loadNotes: function () {
        const savedNotes = localStorage.getItem("notes");
        return savedNotes ? savedNotes : JSON.stringify([]); // Return empty array if no notes
    },
    saveNotes: function (notes) {
        localStorage.setItem("notes", notes);
    }
};
