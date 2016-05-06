System.register([], function(exports_1) {
    var Photo;
    return {
        setters:[],
        execute: function() {
            Photo = (function () {
                function Photo(id, title, uri, albumId, albumTitle, dateUploaded) {
                    this.Id = id;
                    this.Title = title;
                    this.Uri = uri;
                    this.AlbumId = albumId;
                    this.AlbumTitle = albumTitle;
                    this.DateUploaded = dateUploaded;
                }
                return Photo;
            })();
            exports_1("Photo", Photo);
        }
    }
});
