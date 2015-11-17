package com.engineer4myanmar.intakebook;



import android.os.Bundle;
import android.app.Activity;
import android.app.ListActivity;
import android.content.Intent;
import android.support.v4.widget.SimpleCursorAdapter;
import android.util.Log;
import android.view.View;
import android.view.Window;
import android.view.WindowManager;
import android.webkit.WebSettings;
import android.webkit.WebView;
import android.widget.AdapterView;
import android.widget.ListView;
import android.widget.Toast;



public class CadetIBookANYActivity extends ListActivity  {
	
		//int[] imageIDs = {
			//	R.drawable.t1,			R.drawable.t2,
				//R.drawable.t3,			R.drawable.t4,
				//R.drawable.t5,			R.drawable.t6,
				//R.drawable.t7,			R.drawable.t8,
				//R.drawable.t9,			R.drawable.t10				
		//};
		
		String[] strNames={
				"အေနာ္ရထာ တပ္ခြဲ(၁)", "အေနာ္ရထာ  တပ္ခြဲ(၂)", "အေနာ္ရထာ  တပ္ခြဲ(၃)", "အေနာ္ရထာ  တပ္ခြဲ(၄)", "အေနာ္ရထာ  တပ္ခြဲ(၅)" 
				
				};
		public final static String EXTRA_MESSAGE_ANY = "com.engineer4myanmar.intakebook.ANY";
	    
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        requestWindowFeature(Window.FEATURE_NO_TITLE);
        this.getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
        WindowManager.LayoutParams.FLAG_FULLSCREEN);
        //setContentView(R.layout.activity_cadet_ibook_byn);        
        try{
        	Custom_view cv = new Custom_view(this, strNames);
        	setListAdapter(cv);
        }
        catch(Exception e)
        {
        	Log.println(BIND_WAIVE_PRIORITY, "test", e.toString());
        }
        
	}
 
	protected void onListItemClick(ListView l, View v, int position, long id) {
		super.onListItemClick(l, v, position, id);
		// getting the value of clicked item
		String clicked_item = (String) getListAdapter().getItem(position);		
		//Toast.makeText(this, clicked_item, Toast.LENGTH_SHORT).show();
		ShowDefinitionFun(position);
	}

	public void ShowDefinitionFun(int i)
	{
		Intent myIntent = new Intent(this,CadetIBookANYListActivity.class);		
		myIntent.putExtra(EXTRA_MESSAGE_ANY,i);
		startActivity(myIntent);		
		CadetIBookANYActivity.this.finish();
	}
    public void funHome(View v)
    {
    	startActivity(new Intent(CadetIBookANYActivity.this,CadetIBookMainActivity.class));   
    	CadetIBookANYActivity.this.finish();
    }
    @Override
    public void onBackPressed() {
       Log.d("CDA", "onBackPressed Called");
       //System.out .println("onBackPressed Called");
       startActivity(new Intent(CadetIBookANYActivity.this,CadetIBookMainActivity.class));   
   		CadetIBookANYActivity.this.finish();
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
