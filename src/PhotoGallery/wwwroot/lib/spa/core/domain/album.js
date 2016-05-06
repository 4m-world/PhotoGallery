System.register([], function(exports_1) {
    var Album;
    return {
        setters:[],
        execute: function() {
            Album = (function () {
                function Album(id, title, description, thumbnail, dateCreated, totalPhotos) {
                    this.Id = id;
                    this.Title = title;
                    this.Description = description;
                    this.Thumbnail = thumbnail;
                    this.DateCreated = dateCreated;
                    this.TotalPhotos = totalPhotos;
                }
                return Album;
            })();
            exports_1("Album", Album);
        }
    }
});
