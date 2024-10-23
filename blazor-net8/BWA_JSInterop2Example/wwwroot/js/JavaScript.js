function receiveComponentReference(dotNetObjectRef) {
    dotNetObjectRef.invokeMethodAsync('ShowComponentMessage');
}


function initializeClickTracker(dotNetObjectRef) {
    const button = document.getElementById('trackButton');
    button.addEventListener('click', function () {
        dotNetObjectRef.invokeMethodAsync('TrackClick');
        console.log('Button clicked!');
    });
}

function initializeDetailedClickTracker(dotNetObjectRef) {
    const button = document.getElementById('trackButtonDetails');
    button.addEventListener('click', function (event) {
        const elementId = button.id;
        const x = event.clientX;
        const y = event.clientY;

        dotNetObjectRef.invokeMethodAsync('TrackClickWithDetails', elementId, x, y);
        console.log(`Clicked at (${x}, ${y}) on element: ${elementId}`);
    });
}


function initializeClickTrackerWithModel(dotNetObjectRef) {
    const button = document.getElementById('trackButtonDetails2');

    button.addEventListener('click', function (event) {
        const clickDetails = {
            elementId: button.id,
            x: event.clientX,
            y: event.clientY,
            timestamp: new Date()
        };

        // Pass the click details model object to .NET method
        dotNetObjectRef.invokeMethodAsync('TrackClickDetails', clickDetails)
            .then(() => {
                console.log('Click details sent to .NET');
            });
    });
}

function initializeGetClickDetails(dotNetObjectRef) {
    const getDetailsButton = document.getElementById('getClickDetails');
    const messageDisplay = document.getElementById('messageDisplay');

    getDetailsButton.addEventListener('click', function () {
        // Call a .NET method that returns a ClickDetails model object
        dotNetObjectRef.invokeMethodAsync('GetClickDetails')
            .then(clickDetails => {
                messageDisplay.innerHTML = `Element ID: ${clickDetails.elementId}, ` +
                    `Coordinates: (${clickDetails.x}, ${clickDetails.y}), ` +
                    `Timestamp: ${new Date(clickDetails.timestamp).toLocaleString()}`;
            });
    });
}

function initializeGetSimpleMessage(dotNetObjectRef) {
    const getMessageButton = document.getElementById('getSimpleMessage');
    const simpleMessageDisplay = document.getElementById('simpleMessageDisplay');

    getMessageButton.addEventListener('click', function () {
        dotNetObjectRef.invokeMethodAsync('GetSimpleMessage')
            .then(message => {
                simpleMessageDisplay.innerHTML = message;
            });
    });
}
