outlookClient.me.events.getEvents().fetch().then(function (result) {
    result.currentPage.forEach(function (event) {
console.log('Event "' + event.subject + '"')
    });
}, function(error) {
    console.log(error);
});