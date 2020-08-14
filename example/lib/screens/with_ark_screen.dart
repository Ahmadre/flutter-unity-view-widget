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
  int _speedValue = 0;
  String brightness = 'light';
  Color actualColor;

  @override
  void initState() {
    super.initState();
  }

  void setBackground(Color color) {
    _unityWidgetController.postMessage(
      'MainCamera',
      'SetBackgroundColor',
      '${color.red},${color.green},${color.blue}',
    );
  }

  void setCarColor(Color color) {
    Future.delayed(const Duration(seconds: 2), () {
      _unityWidgetController.postMessage(
        'Model3',
        'SetCarColor',
        '${color.red},${color.green},${color.blue}',
      );
    });
  }

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      theme: ThemeData.light().copyWith(scaffoldBackgroundColor: Colors.white),
      darkTheme: ThemeData.dark().copyWith(scaffoldBackgroundColor: Colors.black),
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
                setBackground(Colors.black);
              } else {
                brightness = 'light';
                setBackground(Colors.white);
              }
              setCarColor(Colors.red);
            });
          },
        ),
        body: Container(
          child: SingleChildScrollView(
            physics: AlwaysScrollableScrollPhysics(),
            child: Column(
              mainAxisAlignment: MainAxisAlignment.spaceEvenly,
              mainAxisSize: MainAxisSize.min,
              children: <Widget>[
                Container(
                  height: 300,
                  width: MediaQuery.of(context).size.width,
                  child: UnityWidget(
                    onUnityViewCreated: onUnityCreated,
                    isARScene: false,
                    onUnityMessage: onUnityMessage,
                  ),
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
                Flexible(
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
                        Padding(
                          padding: const EdgeInsets.only(top: 20),
                          child: Text("Car speed:"),
                        ),
                        Slider.adaptive(
                          onChanged: (value) {
                            setState(() {
                              _speedValue = value.toInt();
                            });
                            setCarSpeed(value.toInt());
                          },
                          value: _speedValue.toDouble(),
                          min: 0,
                          max: 100,
                        ),
                      ],
                    ),
                  ),
                ),
              ],
            ),
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

  void setCarSpeed(int speed) {
    _unityWidgetController.postMessage(
      'Model3',
      'SetCarSpeed',
      '$speed',
    );
  }

  void onUnityMessage(controller, message) {
    print('Received message from unity: ${message.toString()}');
  }

  // Callback that connects the created controller to the unity controller
  void onUnityCreated(controller) {
    this._unityWidgetController = controller;
    setBackground(Theme.of(context).scaffoldBackgroundColor);
    setCarColor(Colors.red);
  }
}
