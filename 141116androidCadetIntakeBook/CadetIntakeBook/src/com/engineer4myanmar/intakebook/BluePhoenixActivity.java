package com.engineer4myanmar.intakebook;

import android.os.Bundle;
import android.app.Activity;
import android.view.Menu;
import android.webkit.WebSettings;
import android.webkit.WebView;

public class BluePhoenixActivity extends Activity {

    private static final String URL = "http://www.engineer4myanmar.com";

	@Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_blue_phoenix);
        WebView webView = (WebView) findViewById(R.id.webview1);
        WebSettings settings = webView.getSettings();
        settings.setJavaScriptEnabled(true);
        webView.loadUrl(URL);

        settings.setSupportZoom(true);
        settings.setBuiltInZoomControls(true);
    }

   
}
