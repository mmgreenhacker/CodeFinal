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



public class CadetIBookBYNActivity extends ListActivity  {
	
		//int[] imageIDs = {
			//	R.drawable.t1,			R.drawable.t2,
				//R.drawable.t3,			R.drawable.t4,
				//R.drawable.t5,			R.drawable.t6,
				//R.drawable.t7,			R.drawable.t8,
				//R.drawable.t9,			R.drawable.t10				
		//};
		
		String[] strNames={
				"ဘုရင္႔ေနာင္ တပ္ခြဲ(၁)", "ဘုရင္႔ေနာင္  တပ္ခြဲ(၂)", "ဘုရင္႔ေနာင္  တပ္ခြဲ(၃)", "ဘုရင္႔ေနာင္  တပ္ခြဲ(၄)", "ဘုရင္႔ေနာင္  တပ္ခြဲ(၅)", 
				
				};
		public final static String EXTRA_MESSAGE_BYN= "com.engineer4myanmar.intakebook.BYN";
	    
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
		Intent myIntent = new Intent(this,CadetIBookBYNListActivity.class);		
		myIntent.putExtra(EXTRA_MESSAGE_BYN,i);
		startActivity(myIntent);		
		CadetIBookBYNActivity.this.finish();
	}
    public void funHome(View v)
    {
    	startActivity(new Intent(CadetIBookBYNActivity.this,CadetIBookMainActivity.class));   
    	CadetIBookBYNActivity.this.finish();
    }
    @Override
    public void onBackPressed() {
       Log.d("CDA", "onBackPressed Called");
       //System.out .println("onBackPressed Called");
       startActivity(new Intent(CadetIBookBYNActivity.this,CadetIBookMainActivity.class));   
   		CadetIBookBYNActivity.this.finish();
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
