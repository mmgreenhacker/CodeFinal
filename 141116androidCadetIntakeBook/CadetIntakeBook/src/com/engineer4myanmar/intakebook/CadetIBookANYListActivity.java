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

public class CadetIBookANYListActivity extends Activity {
	int iPosition=0;
	String sTitle="အေနာ္ရထာတပ္ခြဲ(၁)";
	String sQuery;
	ListView lstANY;
	SQLiteConnector sqlConnect;
	private static final String TABLE_RECORD = "cadettb";
	public final static String EXTRA_MESSAGE_ANYDETAIL="com.engineer4myanmar.intakebook.ANYDETAIL";
	public String selectQueryb1 = "SELECT  * FROM " + TABLE_RECORD+" where com='အမွတ္(၁)တပ္ခြဲ' and bat='အေနာ္ရထာတပ္ရင္း' ";
	public String selectQueryb2 = "SELECT  * FROM " + TABLE_RECORD+" where com='အမွတ္(၂)တပ္ခြဲ' and bat='အေနာ္ရထာတပ္ရင္း'";
	public String selectQueryb3 = "SELECT  * FROM " + TABLE_RECORD+" where com='အမွတ္(၃)တပ္ခြဲ' and bat='အေနာ္ရထာတပ္ရင္း'";
	public String selectQueryb4 = "SELECT  * FROM " + TABLE_RECORD+" where com='အမွတ္(၄)တပ္ခြဲ' and bat='အေနာ္ရထာတပ္ရင္း'";
	public String selectQueryb5 = "SELECT  * FROM " + TABLE_RECORD+" where com='အမွတ္(၅)တပ္ခြဲ' and bat='အေနာ္ရထာတပ္ရင္း'";
	//public String selectQueryb6 = "SELECT  * FROM " + TABLE_RECORD+" where com='အမွတ္(၆)တပ္ခြဲ' and bat='အေနာ္ရထာတပ္ရင္း'";
	//public String selectQueryb7 = "SELECT  * FROM " + TABLE_RECORD+" where com='အမွတ္(၇)တပ္ခြဲ' and bat='အေနာ္ရထာတပ္ရင္း'";
	//public String selectQueryb8 = "SELECT  * FROM " + TABLE_RECORD+" where com='အမွတ္(၈)တပ္ခြဲ' and bat='အေနာ္ရထာတပ္ရင္း'";
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        requestWindowFeature(Window.FEATURE_NO_TITLE);
        this.getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
        WindowManager.LayoutParams.FLAG_FULLSCREEN);
        Intent intent = getIntent();
        iPosition = intent.getIntExtra(CadetIBookANYActivity.EXTRA_MESSAGE_ANY,0);        
        setContentView(R.layout.activity_cadet_ibook_anylist);
        TextView tvTitle = (TextView)findViewById(R.id.tvTitle1 );
        
        switch(iPosition+1)
        {
        	case 1: 		sTitle="အေနာ္ရထာတပ္ခြဲ(၁)"; sQuery=selectQueryb1; break;
        	case 2:		sTitle="အေနာ္ရထာတပ္ခြဲ(၂)"; sQuery=selectQueryb2; break;
        	case 3:		sTitle="အေနာ္ရထာတပ္ခြဲ(၃)"; sQuery=selectQueryb3; break;
        	case 4:		sTitle="အေနာ္ရထာတပ္ခြဲ(၄)"; sQuery=selectQueryb4; break;
        	case 5:		sTitle="အေနာ္ရထာတပ္ခြဲ(၅)"; sQuery=selectQueryb5; break;
        	//case 6:		sTitle="အေနာ္ရထာတပ္ခြဲ(၆)"; sQuery=selectQueryb6; break;
        	//case 7:		sTitle="အေနာ္ရထာတပ္ခြဲ(၇)"; sQuery=selectQueryb7; break;
        	//case 8:		sTitle="အေနာ္ရထာတပ္ခြဲ(၈)"; sQuery=selectQueryb8; break;
        	default: 	sTitle="အေနာ္ရထာတပ္ခြဲ(၁)"; sQuery=selectQueryb1; break;
        		
        }
        
        	tvTitle.setText(sTitle);
        	lstANY = (ListView) findViewById(R.id.lstANY);		
      		sqlConnect = new SQLiteConnector(this);
      		//collect all names
      		final ArrayAdapter<String> adapter2 = new ArrayAdapter<String>(this,
      				android.R.layout.simple_list_item_1, sqlConnect.getGroupRecord(2, sQuery));//getAllRecord(2)); // 2 is column number (zero base)
      			
      		lstANY.setAdapter(adapter2);		
      		
      		//Searchable EditText and ListView pair
      		EditText inputSearch = (EditText)findViewById(R.id.txtSearch1 );
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
      		
      		lstANY.setOnItemClickListener(new OnItemClickListener() {
      			  public void onItemClick(AdapterView<?> parent, View view,
      			    int position, long id) {
      			    //Toast.makeText(getApplicationContext(),
      			     //position+ "  -  "+ ((TextView) view).getText(), Toast.LENGTH_LONG)
      			     // .show();
      			    Intent myIntent = new Intent(CadetIBookANYListActivity.this ,CadetIBookANYDetailActivity.class);		
      				myIntent.putExtra(EXTRA_MESSAGE_ANYDETAIL,((TextView) view).getText());
      				startActivity(myIntent);
      			  }
      			}); 		
      	}
    
    public void funHome(View v)
    {
    	startActivity(new Intent(CadetIBookANYListActivity.this,CadetIBookMainActivity.class));   
    	CadetIBookANYListActivity.this.finish();
    }
    
    @Override
    public void onBackPressed() {
       Log.d("CDA", "onBackPressed Called");
       startActivity(new Intent(CadetIBookANYListActivity.this,CadetIBookANYActivity.class));   
   		CadetIBookANYListActivity.this.finish();
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
