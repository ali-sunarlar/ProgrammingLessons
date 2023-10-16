import 'dart:async' show Future;

import 'package:flutter/material.dart';
// #docregion RootBundle
import 'package:flutter/services.dart' show rootBundle;

void main() {
  runApp(const MyHomePage(title: '',));
}

//RootBundle ana varlik yapisina erisim icin kullanilir. Projenin herhangi bir yerinden koke erismeyi saglar. Uygulamadaki herhangi bir degisiklikte kendisine bir yansima olmaz
//BuildContext üzerinden DefaultAssetBundle ile varliklara erisim tavsiye edilmektedir. tema veya diger degisiklerden etkilenir. 

Future<String> loadAsset() async { //asekron tanımlanmış bellege yuklenme sureci asekron tanimlanmasi gerekmektedir.
  return await rootBundle.loadString('assets/config.json');
}




// #enddocregion RootBundle

class MyHomePage extends StatefulWidget {
  const MyHomePage({super.key, required this.title});

  // This widget is the home page of your application. It is stateful, meaning
  // that it has a State object (defined below) that contains fields that affect
  // how it looks.

  // This class is the configuration for the state. It holds the values (in this
  // case the title) provided by the parent (in this case the App widget) and
  // used by the build method of the State. Fields in a Widget subclass are
  // always marked "final".

  final String title;

  @override
  State<MyHomePage> createState() => _MyHomePageState();
}

//Asagidaki gibi tanimlamalarda farkli ebatlarda goruntuleme saglanir.
//.../my_icon.png
//.../2.0x/my_icon.png
//.../3.0x/my_icon.png

//build Context ile tanimlama
class _MyHomePageState extends State<MyHomePage> {
  @override
  Widget build(BuildContext context) {
    // #docregion BackgroundImage
    return const Image(image: AssetImage('assets/background.png'));
    // #enddocregion BackgroundImage
  }
}

//proje icerisinde bulunmayan bir paketin icerisinden gelen. Projeye sonradan dahil edilen bir paketin icerisinde yer alan dosyalar icin bellege aktarilmasi saglanabilir
AssetImage getHeartIconImage() {
  // #docregion PackageImage
  return const AssetImage('icons/heart.png', package: 'my_icons');
  // #enddocregion PackageImage
}