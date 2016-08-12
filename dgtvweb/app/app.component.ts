import { ROUTER_DIRECTIVES }  from '@angular/router';
import { Component } from '@angular/core';
import { EpisodeListComponent } from './episodelist.component';
import { EpisodeService }     from './episode.service';
import { TfHeaderComponent } from './tfHeader.component';


@Component({
  selector: 'my-app',
  templateUrl: '/app/app.html',
  directives: [ROUTER_DIRECTIVES, TfHeaderComponent],
  providers: [
    EpisodeService
  ]

})
export class AppComponent {
  'title' = 'Technology and Friends';
  'subTitle' = 'Talking with smart people about technology';
}
