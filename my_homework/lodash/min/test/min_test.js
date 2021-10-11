import { assertEquals } from "https://deno.land/std@0.63.0/testing/asserts.ts";
import * as _ from "../src/min.js";

Deno.test("min",() => {
    assertEquals(_.min([4, 2, 8, 6]), 2)
    assertEquals(_.min([]), undefined)
})