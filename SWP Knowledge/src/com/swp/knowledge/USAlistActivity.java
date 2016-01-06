package com.swp.knowledge;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

import android.os.Bundle;
import android.annotation.TargetApi;
import android.app.Activity;
import android.content.Context;
import android.content.Intent;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.Toast;
import android.support.v4.app.NavUtils;

public class USAlistActivity extends Activity {
	public final static String EXTRA_MESSAGE_USA = "com.engineer4myanmar.swp.knowledge.USA";
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_usalist);
        final ListView listview = (ListView) findViewById(R.id.listview);
		String[] usaGUNS= new String[] { 
				"37 mm Gun M1", //1
				"90 mm Gun M1A1", //2
				"37 mm Gun M1", //3
				"Oerlikon 20 mm cannon", //4
				"120 mm M1 gun" //5				
				 };
		String[] usaMissiles= new String[] { 
				"RIM – 2 Terrier", //1
				"Nike Ajax", //2
				"Nike Hercules", //3
				"RIM-8 Talos", //4
				"CIM-10 Bomarc", //5				
				"MIM-23 Hawk", //6
				"RIM-24 Tartar", //7
				"FIM-43 Redeye", //8
				"RIM-50 Typhon", //9
				"RIM-7 Sea Sparrow", //10	
				"RIM – 2 Terrier", //11
				"RIM-7 Sea Sparrow", //12
				"MIM-72 Chaparral", //13
				"RIM-67 Standard ER", //14
				"RIM-66 Standard", //15				
				"FIM-92 Stinger", //16
				"AN/TWQ-1 Avenger", //17
				"MIM-104 Patriot", //18
				"Patriot missile", //19
				"Roland (missile)", //20	
				"RIM-116 Rolling Airframe Missile", //21
				"RIM-67 Standard ER", //22
				"RIM-162 ESSM", //23	
				"LAV-25" //24
				 };
		String[] usaRadars= new String[] { 
				"R1", //1
				"R2", //2
				"R3", //3
				"R4", //4
				"R5" //5				
				 };
		final ArrayList<String> list = new ArrayList<String>();
		for (int i = 0; i < usaGUNS.length; ++i) {
			list.add(usaGUNS[i]);
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
				Intent AirDetailIntent = new Intent(USAlistActivity.this,
						USAdetailActivity.class);
				AirDetailIntent.putExtra(EXTRA_MESSAGE_USA, position);
				startActivity(AirDetailIntent);

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
