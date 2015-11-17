package com.engineer4myanmar.intakebook;



import android.os.Bundle;
import android.app.Activity;
import android.content.Intent;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.Window;
import android.view.WindowManager;
import android.webkit.WebSettings;
import android.webkit.WebView;
import android.support.v4.app.NavUtils;

public class CadetIBookMainActivity extends Activity {

    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        requestWindowFeature(Window.FEATURE_NO_TITLE);
        this.getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
        WindowManager.LayoutParams.FLAG_FULLSCREEN);
        setContentView(R.layout.activity_cadet_ibook_main);      
    }
    public void funBYN(View v)
    {
    	startActivity(new Intent(CadetIBookMainActivity.this,CadetIBookBYNActivity.class));
    	CadetIBookMainActivity.this.finish();
    }
    public void funANY(View v)
    {
    	startActivity(new Intent(CadetIBookMainActivity.this,CadetIBookANYActivity.class));
    	CadetIBookMainActivity.this.finish();
    }
    public void funPdfViewer(View v)
    {
    	startActivity(new Intent(CadetIBookMainActivity.this,FileListActivity.class));
    	CadetIBookMainActivity.this.finish();
    }
    public void funSearch(View v)
    {
    	startActivity(new Intent(CadetIBookMainActivity.this,SearchActivity.class));
    	CadetIBookMainActivity.this.finish();
    }
    public void funBluePhoenix(View v)
    {
    	WebView webView = (WebView) findViewById(R.id.webview1);
        WebSettings settings = webView.getSettings();
        settings.setJavaScriptEnabled(true);
        String URL="http://www.engineer4myanmar.com";
		webView.loadUrl(URL);
        settings.setSupportZoom(true);
        settings.setBuiltInZoomControls(true);
    }

}
