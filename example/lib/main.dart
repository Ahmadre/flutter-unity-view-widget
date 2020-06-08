import 'package:flutter/material.dart';
import 'screens/with_ark_screen.dart';

var myApp = MaterialApp(
  theme: ThemeData(
    scaffoldBackgroundColor: Colors.white,
  ),
  title: 'Named Routes Demo',
  // Start the app with the "/" named route. In this case, the app starts
  // on the FirstScreen widget.
  initialRoute: '/',
  routes: {
  '/': (context) => WithARkitScreen(),
  '/ar': (context) => WithARkitScreen(),
  },
);

void main() => runApp(myApp);