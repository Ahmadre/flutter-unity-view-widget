import 'package:flutter/material.dart';
import 'package:flutter_unity_widget/flutter_unity_widget.dart';

class WithARkitScreen extends StatefulWidget {
  @override
  _WithARkitScreenState createState() => _WithARkitScreenState();
}

class _WithARkitScreenState extends State<WithARkitScreen> {
  static final GlobalKey<ScaffoldState> _scaffoldKey = GlobalKey<ScaffoldState>();
  UnityWidgetController _unityWidgetController;
  double _sliderValue = 0.0;
  String brightness = 'light';
  Color actualColor;

  @override
  void initState() {
    super.initState();
  }

  void setBackground() {
    final color = Theme.of(context).scaffoldBackgroundColor;
    _unityWidgetController.postMessage(
      'MainCamera',
      'setBackgroundColor',
      '${color.red},${color.green},${color.blue}',
    );
  }

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      theme: ThemeData.light(),
      darkTheme: ThemeData.dark(),
      themeMode: brightness == 'light' ? ThemeMode.light : ThemeMode.dark,
      home: Scaffold(
        key: _scaffoldKey,
        appBar: AppBar(
          title: const Text('Unity Flutter Demo'),
        ),
        floatingActionButton: FloatingActionButton(
          child: Icon(brightness == 'light' ? Icons.brightness_4 : Icons.brightness_7),
          onPressed: () {
            setState(() {
              if (brightness == 'light') {
                brightness = 'dark';
              } else {
                brightness = 'light';
              }
              setBackground();
            });
          },
        ),
        body: Container(
          margin: const EdgeInsets.all(8),
          child: Stack(
            fit: StackFit.expand,
            children: <Widget>[
              UnityWidget(
                onUnityViewCreated: onUnityCreated,
                isARScene: false,
                onUnityMessage: onUnityMessage,
              ),
              Wrap(
                children: [
                  RaisedButton.icon(
                    onPressed: openDriverFrontDoor,
                    icon: Icon(Icons.lock_open),
                    label: Text('Fahrertür öffnen'),
                  ),
                  RaisedButton.icon(
                    onPressed: closeDriverFrontDoor,
                    icon: Icon(Icons.lock),
                    label: Text('Fahrertür schließen'),
                  ),
                  RaisedButton.icon(
                    onPressed: openPassengerFrontDoor,
                    icon: Icon(Icons.lock_open),
                    label: Text('Beifahrertür öffnen'),
                  ),
                  RaisedButton.icon(
                    onPressed: closePassengerFrontDoor,
                    icon: Icon(Icons.lock),
                    label: Text('Beifahrertür schließen'),
                  ),
                  RaisedButton.icon(
                    onPressed: openFrunk,
                    icon: Icon(Icons.lock_open),
                    label: Text('Frunk öffnen'),
                  ),
                  RaisedButton.icon(
                    onPressed: closeFrunk,
                    icon: Icon(Icons.lock),
                    label: Text('Frunk schließen'),
                  ),
                  RaisedButton.icon(
                    onPressed: openTrunk,
                    icon: Icon(Icons.lock_open),
                    label: Text('Trunk öffnen'),
                  ),
                  RaisedButton.icon(
                    onPressed: closeTrunk,
                    icon: Icon(Icons.lock),
                    label: Text('Trunk schließen'),
                  ),
                ],
              ),
              Positioned(
                bottom: 20,
                left: 20,
                right: 20,
                child: Card(
                  elevation: 10,
                  child: Column(
                    children: <Widget>[
                      Padding(
                        padding: const EdgeInsets.only(top: 20),
                        child: Text("Rotation speed:"),
                      ),
                      Slider.adaptive(
                        onChanged: (value) {
                          setState(() {
                            _sliderValue = value;
                          });
                          setRotationSpeed(value.toString());
                        },
                        value: _sliderValue,
                        min: 0,
                        max: 20,
                      ),
                    ],
                  ),
                ),
              ),
            ],
          ),
        ),
      ),
    );
  }

  void setRotationSpeed(String speed) {
    _unityWidgetController.postMessage(
      'Model3',
      'SetRotationSpeed',
      speed,
    );
  }

  void openDriverFrontDoor() {
    _unityWidgetController.postMessage(
      'Model3',
      'DoorOpened',
      'driverfrontdoor:true',
    );
  }

  void closeDriverFrontDoor() {
    _unityWidgetController.postMessage(
      'Model3',
      'DoorOpened',
      'driverfrontdoor:false',
    );
  }

  void openPassengerFrontDoor() {
    _unityWidgetController.postMessage(
      'Model3',
      'DoorOpened',
      'passengerfrontdoor:true',
    );
  }

  void closePassengerFrontDoor() {
    _unityWidgetController.postMessage(
      'Model3',
      'DoorOpened',
      'passengerfrontdoor:false',
    );
  }

  void openTrunk() {
    _unityWidgetController.postMessage(
      'Model3',
      'DoorOpened',
      'trunk:true',
    );
  }

  void closeTrunk() {
    _unityWidgetController.postMessage(
      'Model3',
      'DoorOpened',
      'trunk:false',
    );
  }

  void openFrunk() {
    _unityWidgetController.postMessage(
      'Model3',
      'DoorOpened',
      'frunk:true',
    );
  }

  void closeFrunk() {
    _unityWidgetController.postMessage(
      'Model3',
      'DoorOpened',
      'frunk:false',
    );
  }

  void onUnityMessage(controller, message) {
    print('Received message from unity: ${message.toString()}');
  }

  // Callback that connects the created controller to the unity controller
  void onUnityCreated(controller) {
    this._unityWidgetController = controller;
    setBackground();
  }
}
