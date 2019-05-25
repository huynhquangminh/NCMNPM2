import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RoomdetailComponent } from './roomdetail.component';

describe('RoomdetailComponent', () => {
  let component: RoomdetailComponent;
  let fixture: ComponentFixture<RoomdetailComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RoomdetailComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RoomdetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
