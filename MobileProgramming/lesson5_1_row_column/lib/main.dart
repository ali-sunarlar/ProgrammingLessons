import 'package:flutter/material.dart';
import 'package:flutter/rendering.dart' show debugPaintSizeEnabled;

void main() {
  debugPaintSizeEnabled = true; // Remove to suppress visual layout
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Flutter layout demo',
      home: Scaffold(
        appBar: AppBar(
          title: const Text('Flutter layout demo'),
        ),
        // Change to buildColumn() for the other column example
        body: Center(child: buildRow()),
      ),
    );
  }

  Widget buildRow() =>
      // #docregion Row
      Row(
        crossAxisAlignment: CrossAxisAlignment.center,
        children: [
          Expanded(child: Image.asset('images/pic1.jpg'),),
          Expanded(
          flex:2,
          child: Image.asset('images/pic2.jpg'),),
          Expanded(child: Image.asset('images/pic3.jpg'),),
        ],
      );
  // #enddocregion Row

  Widget buildColumn() =>
      // #docregion Column
      Column(
        crossAxisAlignment: CrossAxisAlignment.center,
        children: [
          Expanded(child: Image.asset('images/pic1.jpg'),),
          Expanded(
          flex:2,
          child: Image.asset('images/pic2.jpg'),),
          Expanded(child: Image.asset('images/pic3.jpg'),),
        ],
      );
  // #enddocregion Column
}