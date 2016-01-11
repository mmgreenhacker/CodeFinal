package com.swp.knowledge;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

import android.os.Bundle;
import android.annotation.TargetApi;
import android.app.Activity;
import android.content.Context;
import android.content.Intent;
import android.util.Log;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.Window;
import android.view.WindowManager;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.Toast;
import android.support.v4.app.NavUtils;

public class INDIAlistActivity extends Activity {
	public final static String EXTRA_MESSAGE_INDIA_POSITION= "com.engineer4myanmar.swp.knowledge.INDIA.POSITION";
	public final static String EXTRA_MESSAGE_INDIA_TYPE = "com.engineer4myanmar.swp.knowledge.INDIA.TYPE";
	
	int iType=0;
	String[] indiaGUNS = new String[] { 
			"40 mm L40/70 LAAG", // 1
			"23 mm ZSU-23- 4M SPAAG (Shilka)", // 1
			
	};
	String[] indiaMissiles = new String[] { 
			//indiam
			"9K22 Tunguska (Self-propelled Anti-aircraft Weapon)", // 1
			"SA-7", // 2
			"SA-16", // 3
			"SA-18 Grouse", // 4
			"SA-8 Gecko SAM", // 5
			"SA-9 Gaskin Low altitude SAM", // 6
			"9K35 Strela-10 (NATO Reporting Name: SA-13 Gopher)", // 7
			"SA-10 C PMU-2", // 8
			"S-75 Dvina (SA-2 Guideline)", // 9
			"SA-3 (Pechora-1 and 2) Goa", // 10
			"Trishul Missile System (Short-range Surface to Air Missile)", // 11
			"AKASH SAM (Medium-range Surface to Air Missile)", // 12
			"SPYDER Low-level, Quick-reaction, Surface-to-air Missile(llqrm)", // 13
			"Prithvi Air Defence (PAD) / Pradyumna Ballistic Missile Interceptor", // 14
			"Advanced Air Defence (AAD)/Ashwin Ballistic Missile Interceptor", // 15
			"Agni-V", // 16
			"BrahMos", // 17
			"Prahaar", // 18
			"Prithvi-II", // 19
			"Shaurya", // 20
	};
	String[] indiaRadars = new String[] { 
			"Indra-II Radar", // 1
			"Rohini", // 2
			
	};

	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);		
		requestWindowFeature(Window.FEATURE_NO_TITLE);
		this.getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
				WindowManager.LayoutParams.FLAG_FULLSCREEN);
		Intent intent = getIntent();
		iType = intent.getIntExtra(IndiaActivity.EXTRA_MESSAGE_INDIA, 0);
		Log.d("itype",String.valueOf(iType));
		setContentView(R.layout.activity_indialist);
		//Toast.makeText(getApplicationContext(), "OK",Toast.LENGTH_SHORT).show();
		
		final ListView listview = (ListView) findViewById(R.id.listviewINDIA);
		final ArrayList<String> list = new ArrayList<String>();
		switch (iType) {
		case 1:
			for (int i = 0; i < indiaRadars.length; ++i) {
				list.add(indiaRadars[i]);
			}
			break;
		case 2:
			for (int i = 0; i < indiaGUNS.length; ++i) {
				list.add(indiaGUNS[i]);
			}
			break;
		case 3:
			for (int i = 0; i < indiaMissiles.length; ++i) {
				list.add(indiaMissiles[i]);
			}
			break;
		}

	
		final StableArrayAdapter adapter = new StableArrayAdapter(this,
				android.R.layout.simple_list_item_1, list);
		listview.setAdapter(adapter);

		listview.setOnItemClickListener(new AdapterView.OnItemClickListener() {

			@TargetApi(16)
			public void onItemClick(AdapterView<?> parent, final View view,
					int position, long id) {
				final String item = (String) parent.getItemAtPosition(position);
				Toast.makeText(getApplicationContext(), item,
						Toast.LENGTH_SHORT).show();
				Intent INDIAlistIntent = new Intent(INDIAlistActivity.this,
						INDIAdetailActivity.class);
				INDIAlistIntent.putExtra(EXTRA_MESSAGE_INDIA_POSITION, position);
				INDIAlistIntent.putExtra(EXTRA_MESSAGE_INDIA_TYPE, iType);
				startActivity(INDIAlistIntent);

				// great animation to delete items
				// view.animate().setDuration(2000).alpha(0)
				// .withEndAction(new Runnable() {
				// public void run() {
				// list.remove(item);
				// adapter.notifyDataSetChanged();
				// view.setAlpha(1);
				// }
				// });
			}

		});
	}

	private class StableArrayAdapter extends ArrayAdapter<String> {

		HashMap<String, Integer> mIdMap = new HashMap<String, Integer>();

		public StableArrayAdapter(Context context, int textViewResourceId,
				List<String> objects) {
			super(context, textViewResourceId, objects);
			for (int i = 0; i < objects.size(); ++i) {
				mIdMap.put(objects.get(i), i);
			}
		}

		public long getItemId(int position) {
			String item = getItem(position);
			return mIdMap.get(item);
		}

		public boolean hasStableIds() {
			return true;
		}

	}
}
