package com.engineer4myanmar.intakebook;

import android.os.Bundle;
import android.app.Activity;
import android.content.Intent;
import android.util.Log;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.Window;
import android.view.WindowManager;
import android.webkit.WebSettings;
import android.webkit.WebView;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;
import android.widget.AdapterView.OnItemClickListener;
import android.support.v4.app.NavUtils;
import android.text.Editable;
import android.text.TextWatcher;

public class SearchActivity extends Activity {
	int iPosition=0;
	String sTitle="17th Intake Book Search Engine";
	String sQuery;
	ListView lstSEARCH;
	SQLiteConnector sqlConnect;
	private static final String TABLE_RECORD = "cadettb";
	public final static String EXTRA_MESSAGE_SEARCHDETAIL="com.engineer4myanmar.intakebook.SEARCHDETAIL";
	public String selectQuery = "SELECT  * FROM " + TABLE_RECORD;
	
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        requestWindowFeature(Window.FEATURE_NO_TITLE);
        this.getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
        WindowManager.LayoutParams.FLAG_FULLSCREEN);
        Intent intent = getIntent();
        iPosition = intent.getIntExtra(CadetIBookANYActivity.EXTRA_MESSAGE_ANY,0);        
        setContentView(R.layout.activity_search);
        TextView tvTitle = (TextView)findViewById(R.id.tvTitleSearch );     
           	    
        
        	tvTitle.setText(sTitle);
        	lstSEARCH = (ListView) findViewById(R.id.lstSearch);		
      		sqlConnect = new SQLiteConnector(this);
      		//collect all names
      		final ArrayAdapter<String> adapter2 = new ArrayAdapter<String>(this,
      				android.R.layout.simple_list_item_1, sqlConnect.getGroupRecord(2, selectQuery));//getAllRecord(2)); // 2 is column number (zero base)
      			
      		lstSEARCH.setAdapter(adapter2);		
      		
      		//Searchable EditText and ListView pair
      		EditText inputSearch = (EditText)findViewById(R.id.txtSearch );
      		inputSearch.addTextChangedListener(new TextWatcher() {		     
      		    public void onTextChanged(CharSequence cs, int arg1, int arg2, int arg3) {
      		        // When user changed the Text
      		    	adapter2.getFilter().filter(cs);		        
      		    }
      		    
      		    public void beforeTextChanged(CharSequence arg0, int arg1, int arg2,
      		            int arg3) {
      		        // TODO Auto-generated method stub		         
      		    }
      		     
      		    public void afterTextChanged(Editable arg0) {
      		        // TODO Auto-generated method stub                         
      		    }
      		});
      		
      		lstSEARCH.setOnItemClickListener(new OnItemClickListener() {
      			  public void onItemClick(AdapterView<?> parent, View view,
      			    int position, long id) {
      			    //Toast.makeText(getApplicationContext(),
      			     //position+ "  -  "+ ((TextView) view).getText(), Toast.LENGTH_LONG)
      			     // .show();
      			    Intent myIntent = new Intent(SearchActivity.this ,SearchDetailActivity.class);		
      				myIntent.putExtra(EXTRA_MESSAGE_SEARCHDETAIL,((TextView) view).getText());
      				startActivity(myIntent);
      			  }
      			}); 		
      	}
    
    public void funHome(View v)
    {
    	startActivity(new Intent(SearchActivity.this,CadetIBookMainActivity.class));   
    	SearchActivity.this.finish();
    }
    
    @Override
    public void onBackPressed() {
       Log.d("CDA", "onBackPressed Called");
       startActivity(new Intent(SearchActivity.this,CadetIBookMainActivity.class));   
   		SearchActivity.this.finish();
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
