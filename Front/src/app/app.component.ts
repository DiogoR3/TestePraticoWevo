import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  constructor() { }

  ngOnInit() {

  }

  changeTheme(isDark: Boolean) {
    console.log(isDark)
  }
}
