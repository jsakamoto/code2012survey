このソースコードは何か?
====================

このソースコードは、Code2012 イベント用に企画された、「何故あなたはコードを書くのでしょうか?」アンケートの、フロントエンド側 UI アプリです。

実装テクノロジ
------------
.NET Framework 4.0 上で、C# + ASP.NET MVC4 を使って書かれています。

開発環境には、Windows7(x64) + Visual Studio 2012 Professional RC を使用しました。

Visual Studio は Express Edition でもこのソースからビルドできるのかは未確認です。

バックエンド側 API
----------------
このアプリから、Ruby on Rails で作成され、Heroku に配置されているバックエンド側 API へ、入力されたアンケート回答内容を POST しています。

バックエンド側 API の URL はこちら。
http://code-survey.herokuapp.com/

練習用の "ステージング" 環境もあります。
http://stage-code-survey.herokuapp.com/

配置先
-----
このフロントエンド側 UI アプリを、Windows Azure Website と AppHarbor の 2つの PaaS へ配置してあります。

http://code2012survey.azurewebsites.net/
http://code2012survey.apphb.com

そのほか
-------
このアンケート Web システムについて、ブログ記事でも説明しています。
http://devadjust.exblog.jp/16304882/

